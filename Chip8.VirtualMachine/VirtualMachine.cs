// ReSharper disable InconsistentNaming

using System.Diagnostics;
using System.Text;

namespace Chip8;

public class VirtualMachine
{
    internal static readonly int StackSize = 0xC;
        
    /// <summary>
    ///     Program Counter (a.k.a. instruction pointer)
    /// </summary>
    internal ushort PC { get; set; } = 0x200;

    /// <summary>
    ///     16-bit register used for memory addresses
    /// </summary>
    internal ushort I { get; set; }

    /// <summary>
    ///     8-bit registers (V0-VF)
    /// </summary>
    internal byte[] V { get; } = new byte[16];

    internal byte VF
    {
        get => V[0xF];
        set => V[0xF] = value;
    } 
        
    internal byte V0
    {
        get => V[0];
        set => V[0] = value;
    } 
    
    /// <summary>
    ///     Tracks key presses
    /// </summary>
    internal byte[] Keys { get; } = new byte[16];

    /// <summary>
    ///     4096 bytes of RAM
    /// </summary>
    internal byte[] Memory { get; } = new byte[4096];
    
    /// <summary>
    ///     Stack; stores 16-bit return addresses when subroutine is called
    /// </summary>
    internal ushort[] Stack { get; } = new ushort[StackSize];

    /// <summary>
    ///     Stack Pointer
    /// </summary>
    internal int SP { get; set; }

    /// <summary>
    ///     Used for timing events
    /// </summary>
    internal byte SoundTimer { get; set; }
    
    /// <summary>
    ///     Used for sound effects
    /// </summary>
    internal byte DelayTimer { get; set; }

    /// <summary>
    ///     Signals whether or not to stop program execution
    /// </summary>
    internal bool IsStopped { get; set; }
    
    /// <summary>
    ///     Decodes opcodes into instructions
    /// </summary>
    private readonly IDecoder _decoder;

    /// <summary>
    ///     Screen that the virtual machine can draw on
    /// </summary>
    internal readonly IDisplay Display;

    internal bool Refresh;

    private readonly IRomReader _romReader;

    public VirtualMachine(IDisplay display): this(new Decoder(), display, RomReader.Create()) { }
    
    internal VirtualMachine(): this(new Decoder(), new NoDisplay(), RomReader.Create()) { }
    
    internal VirtualMachine(IDecoder decoder, IDisplay display, IRomReader romReader)
    {
        _decoder = decoder;
        Display = display;
        _romReader = romReader;
    }

    public void RunProgram(string romPath)
    {
        SP = 0;
        SoundTimer = 0;
        DelayTimer = 0;
        Refresh = false;
        IsStopped = false;
        
        LoadFonts();
            
        LoadRom(romPath);
        
        // 500-600 Hz is the recommended average, but that is way too fast
        var targetRefreshRateInTicks 
            = TimeSpan.FromTicks(TimeSpan.TicksPerSecond / 210).Ticks;
        
        var stopWatch = Stopwatch.StartNew();
        
        while (!IsStopped)
        {
            var startCycle = stopWatch.ElapsedTicks;
            Step();
            
            if (Refresh)
            {
                Display.Paint();
                Refresh = false;
            }
            
            // TODO: KeyPresses seem to get cleared too quickly
            KeyPressInterrupt();
            
            var endCycle = stopWatch.ElapsedTicks;
            var elapsedTicks = endCycle - startCycle;
            if (elapsedTicks < targetRefreshRateInTicks)
            {
                var waitTime = new TimeSpan(targetRefreshRateInTicks - elapsedTicks);
                Thread.Sleep(waitTime);
            }
        }
    }

    private void KeyPressInterrupt()
    {
        if (Console.KeyAvailable)
        {
            LogKeyPress();
        }
        else
        {
            ClearKeyPresses();
        }
    }

    private void LogKeyPress()
    {
        var keyPress = Console.ReadKey(true).Key;
        switch (keyPress)
        {
            case ConsoleKey.D1: Keys[0x1] = 1; break;
            case ConsoleKey.D2: Keys[0x2] = 1; break;
            case ConsoleKey.D3: Keys[0x3] = 1; break;
            case ConsoleKey.D4: Keys[0xC] = 1; break;
            case ConsoleKey.Q: Keys[0x4] = 1; break;
            case ConsoleKey.W: Keys[0x5] = 1; break;
            case ConsoleKey.E: Keys[0x6] = 1; break;
            case ConsoleKey.R: Keys[0xD] = 1; break;
            case ConsoleKey.A: Keys[0x7] = 1; break;
            case ConsoleKey.S: Keys[0x8] = 1; break;
            case ConsoleKey.D: Keys[0x9] = 1; break;
            case ConsoleKey.F: Keys[0xE] = 1; break;
            case ConsoleKey.Z: Keys[0xA] = 1; break;
            case ConsoleKey.X: Keys[0x0] = 1; break;
            case ConsoleKey.C: Keys[0xB] = 1; break;
            case ConsoleKey.V: Keys[0xF] = 1; break;
            case ConsoleKey.Escape: IsStopped = true; break;
        }
    }

    private void ClearKeyPresses()
    {
        Keys[0x0] = Keys[0x1] = 0;
        Keys[0x2] = 0;
        Keys[0x3] = 0;
        Keys[0x4] = 0;
        Keys[0x5] = 0;
        Keys[0x6] = 0;
        Keys[0x7] = 0;
        Keys[0x8] = 0;
        Keys[0x9] = 0;
        Keys[0xA] = 0;
        Keys[0xB] = 0;
        Keys[0xC] = 0;
        Keys[0xD] = 0;
        Keys[0xE] = 0;
        Keys[0xF] = 0;
    }

    /// <summary>
    ///     Copies ASCII fonts into memory
    /// </summary>
    internal void LoadFonts()
    {
        for (var i = 0; i < 80; ++i)
            Memory[i] = FontSet.ASCII[i];
    }

    /// <summary>
    ///     Copies a program (rom) into memory
    /// </summary>
    /// <param name="filepath">
    ///     Path to the rom
    /// </param>
    internal void LoadRom(string filepath)
    {
        var memoryIndex = 0x200;
        foreach (var b in _romReader.ReadRomAsBytes(filepath))
        {
            Memory[memoryIndex++] = b;
        }
    }

    /// <summary>
    ///     Fetch, decode, and execute the next instruction
    /// </summary>
    internal void Step()
    {
        var opcode = Fetch();
        var instruction = _decoder.Decode(opcode);
        instruction.Execute(this);

        if (DelayTimer > 0)
        {
            DelayTimer--;
        }

        if (SoundTimer > 0)
        {
            if (SoundTimer == 1)
            {
                // play sound 
            }

            SoundTimer--;
        }
    }

    /// <summary>
    ///     Gets current Opcode from memory based on current PC
    /// </summary>
    /// <returns>
    ///     16-bit opcode (e.g 0x3D10)
    /// </returns>
    internal ushort Fetch()
    {
        if (Memory.Length <= PC + 1)
        {
            IsStopped = true;
            return 0x0;
        }
        var hi = Memory[PC];
        var lo = Memory[PC + 1];
        return (ushort)(hi << 8 | lo);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        for(var i = 0; i < 16; i++)
            sb.Append($"V{i:X}=0x{V[i]:X2} ");
        sb.AppendLine();
        sb.Append($"PC={PC} ").Append($"SP={SP} ").Append($"I={I} ")
            .Append($"Delay={DelayTimer} ").Append($"Sound={SoundTimer} ");
        return sb.ToString();
    }
}
