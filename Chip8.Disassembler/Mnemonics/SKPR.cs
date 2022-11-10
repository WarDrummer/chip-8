// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class SKPR : OpcodeToTextParser, IMnemonic
{
    internal SKPR(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return $"SKPR {X}";
    }
}
