// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class ADDI : OpcodeToTextParser, IMnemonic
{
    internal ADDI(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return $"ADDI {X}";
    }
}
