using System.Text;

namespace Chip8.Display.Console;

using Console = System.Console;

public class ConsoleDisplay : IDisplay
{
    private const int ScreenWidth = 64;
    private const int ScreenHeight = 32;
    private const int ScreenSize = ScreenWidth * ScreenHeight;
   // private const string On = "🀫";
   // private const string Off = "🀆";
    private const string On = "#";
    private const string Off = " ";
    private readonly StringBuilder _sb = new(ScreenSize);
    
    public byte[] Pixels { get; set; } = new byte[ScreenSize];

    public ConsoleDisplay()
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
        _sb.Clear();
        for (var y = 0; y < ScreenHeight; y++)
        {
            var iOffset = y * ScreenWidth;
            for (var x = 0; x < ScreenWidth; x++)
            {
                _sb.Append(Pixels[iOffset + x] > 0 ? On : Off);
            }

            _sb.AppendLine();
        }
        
        Console.SetCursorPosition(0,0);
        Console.WriteLine(_sb.ToString());
    }
}
