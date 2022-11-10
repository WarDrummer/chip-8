// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class STOR : OpcodeToTextParser, IMnemonic
{
    internal STOR(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return $"STOR {X}";
    }
}
