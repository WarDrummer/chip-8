// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class SHR : OpcodeToTextParser, IMnemonic
{
    internal SHR(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return $"SHR {X}, {Y}";
    }
}
