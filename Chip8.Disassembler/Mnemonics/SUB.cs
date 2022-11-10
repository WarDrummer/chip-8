// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class SUB : OpcodeToTextParser, IMnemonic
{
    internal SUB(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return $"SUB {X}, {Y}";
    }
}
