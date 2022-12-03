using System.Diagnostics;

namespace Chip8.IO.ConsoleKeyboard;

public class ConsoleKeyboard : IKeyboard
{
    private readonly byte[] _keys = new byte[16];
    public bool IsExited { get; private set; }

    public byte this[byte index]
    {
        get
        {
            Debug.Assert(index < 16);
            return _keys[index];
        }
        set
        {
            Debug.Assert(index < 16);
            _keys[index] = value;
        }
    }
    
    public void ReadKey()
    {
        if (!Console.KeyAvailable)
        {
            return;
        }

        var keyPress = Console.ReadKey(true).Key;
        ClearKeyPresses();
        switch (keyPress)
        {
            case ConsoleKey.D1: this[0x1] = 1; break;
            case ConsoleKey.D2: this[0x2] = 1; break;
            case ConsoleKey.D3: this[0x3] = 1; break;
            case ConsoleKey.D4: this[0xC] = 1; break;
            case ConsoleKey.Q: this[0x4] = 1; break;
            case ConsoleKey.W: this[0x5] = 1; break;
            case ConsoleKey.E: this[0x6] = 1; break;
            case ConsoleKey.R: this[0xD] = 1; break;
            case ConsoleKey.A: this[0x7] = 1; break;
            case ConsoleKey.S: this[0x8] = 1; break;
            case ConsoleKey.D: this[0x9] = 1; break;
            case ConsoleKey.F: this[0xE] = 1; break;
            case ConsoleKey.Z: this[0xA] = 1; break;
            case ConsoleKey.X: this[0x0] = 1; break;
            case ConsoleKey.C: this[0xB] = 1; break;
            case ConsoleKey.V: this[0xF] = 1; break;
            case ConsoleKey.Escape: IsExited = true; break;
        }
    }
    
    public virtual void ClearKeyPresses()
    {
        _keys[0x0] = _keys[0x1] = _keys[0x2] = _keys[0x3] =
        _keys[0x4] = _keys[0x5] = _keys[0x6] = _keys[0x7] =
        _keys[0x8] = _keys[0x9] = _keys[0xA] = _keys[0xB] =
        _keys[0xC] = _keys[0xD] = _keys[0xE] = _keys[0xF] 
            = 0;
    }

    public virtual void Reset()
    {
        IsExited = false;
        ClearKeyPresses();
    }
}
