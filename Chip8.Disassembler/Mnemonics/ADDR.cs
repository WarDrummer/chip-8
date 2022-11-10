// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class ADDR : OpcodeToTextParser, IMnemonic
{
    internal ADDR(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return $"ADDR {X}, {Y}";
    }
}
