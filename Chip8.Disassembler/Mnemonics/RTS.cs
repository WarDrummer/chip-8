// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class RTS : IMnemonic
{
    public string Disassemble()
    {
        return "RTS";
    }
}
