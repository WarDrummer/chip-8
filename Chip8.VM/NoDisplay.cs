
using Chip8.Display;

namespace Chip8.VM;

internal class NoDisplay : IDisplay
{
    public byte[] Pixels { get; set; } = new byte[32 * 64];
    public void Clear() { }
    public void Paint() { }
}
