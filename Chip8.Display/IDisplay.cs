namespace Chip8.Display;

public interface IDisplay
{
    byte[] Pixels { get; set; }

    void Clear();
    void Paint();
}