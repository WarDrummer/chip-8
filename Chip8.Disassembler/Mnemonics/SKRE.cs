// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class SKRE : OpcodeToTextParser, IMnemonic
{
    internal SKRE(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return $"SKRE {X}, {Y}";
    }
}
