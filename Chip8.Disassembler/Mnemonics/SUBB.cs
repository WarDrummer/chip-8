// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class SUBB : OpcodeToTextParser, IMnemonic
{
    internal SUBB(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return $"SUBB {X}, {Y}";
    }
}
