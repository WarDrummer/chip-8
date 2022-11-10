// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class AND : OpcodeToTextParser, IMnemonic
{
    internal AND(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return $"AND {X}, {Y}";
    }
}
