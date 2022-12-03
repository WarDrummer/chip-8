namespace Chip8;

public interface IKeyboard
{
    bool IsExited { get; }
    byte this[byte index] { get; set; }
    void ReadKey();
    void ClearKeyPresses();
    void Reset();
}