// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class MOVE : OpcodeToTextParser, IMnemonic
{
    internal MOVE(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return $"MOVE {X}, {Y}";
    }
}
