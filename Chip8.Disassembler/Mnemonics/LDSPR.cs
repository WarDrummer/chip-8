// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class LDSPR : OpcodeToTextParser, IMnemonic
{
    internal LDSPR(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return $"LDSPR {X}";
    }
}
