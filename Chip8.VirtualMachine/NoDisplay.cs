
namespace Chip8;

internal class NoDisplay : IDisplay
{
    public byte[] Pixels { get; set; } = new byte[32 * 64];
    public void Clear() { }
    public void Paint() { }
}