// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class BCD : OpcodeToTextParser, IMnemonic
{
    internal BCD(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return $"BCD {X}";
    }
}
