// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class DRAW : OpcodeToTextParser, IMnemonic
{
    internal DRAW(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return $"DRAW {X}, {Y}, {N}";
    }
}
