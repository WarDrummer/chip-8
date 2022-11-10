// ReSharper disable InconsistentNaming

using System.Text;
using Chip8.Decoder;

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

    private readonly IRomReader _romReader;

    public VirtualMachine(IDisplay display): this(new Decoder.Decoder(), display, RomReader.Create()) { }
    
    internal VirtualMachine(): this(new Decoder.Decoder(), new NoDisplay(), RomReader.Create()) { }
    
    internal VirtualMachine(IDecoder decoder, IDisplay display, IRomReader romReader)
    {
        _decoder = decoder;
        Display = display;
        _romReader = romReader;
    }

    public void RunProgram(string romPath)
    {
        LoadFonts();
            
        LoadRom(romPath);

        SP = 0;
        SoundTimer = 0;
        DelayTimer = 0;
        IsStopped = false;

        while (!IsStopped)
        {
            Step();
            Display.Paint();
        }
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
        //Console.WriteLine($"0x{opcode:X4} @ PC={PC}");// : {instruction.ToString()?.Split(".").Last()}");
        instruction.Execute(this);
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
