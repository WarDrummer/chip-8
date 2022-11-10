// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class OR : OpcodeToTextParser, IMnemonic
{
    internal OR(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return $"OR {X}, {Y}";
    }
}
