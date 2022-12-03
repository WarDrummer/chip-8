namespace Chip8.IO;

public class NoKeyboard : IKeyboard
{
    private readonly byte[] _keys = new byte[16];
    public bool IsExited => false;

    public byte this[byte index]
    {
        get => _keys[index];
        set => _keys[index] = value;
    }

    public void ReadKey()
    {
    }

    public void ClearKeyPresses()
    {
 
    }

    public void Reset()
    {
    }
}
