namespace Chip8;

public interface IDisplay
{
    byte[] Pixels { get; set; }

    void Clear();
    void Paint();
}
