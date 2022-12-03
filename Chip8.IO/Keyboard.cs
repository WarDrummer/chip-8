using System.Diagnostics;

namespace Chip8;

public abstract class Keyboard
{
    private readonly byte[] _keys = new byte[16];
    public bool IsExited { get; protected set; }

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
    
    public abstract void ReadKey();

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
