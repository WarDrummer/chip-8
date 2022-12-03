namespace Chip8.IO.Display;

public class ConsoleDirectDisplay : IDisplay
{
    private const int ScreenWidth = 64;
    private const int ScreenHeight = 32;
    private const int ScreenSize = ScreenWidth * ScreenHeight;
    // private const string On = "🀫";
    // private const string Off = "🀆";
    private const string On = "#";
    private const string Off = " ";
    
    public byte[] Pixels { get; set; } = new byte[ScreenSize];

    public ConsoleDirectDisplay()
    {
        Console.CursorVisible = false;
        Console.Clear();
    }

    public void Clear()
    {
        Pixels = new byte[ScreenSize];
    }

    public void Paint()
    {
        Console.SetCursorPosition(0,0);
        for (var y = 0; y < ScreenHeight; y++)
        {
            var iOffset = y * ScreenWidth;
            for (var x = 0; x < ScreenWidth; x++)
            {
                Console.Write(Pixels[iOffset + x] > 0 ? On : Off);
            }

            Console.WriteLine();
        }
    }
}
