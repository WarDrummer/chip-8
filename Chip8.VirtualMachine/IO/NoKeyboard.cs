namespace Chip8.IO;

public class NoKeyboard : IKeyboard
{
    public bool IsExited => false;

    public byte this[byte index]
    {
        get => 0;
        set { }
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
