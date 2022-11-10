// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class KEYD : OpcodeToTextParser, IMnemonic
{
    internal KEYD(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return $"KEYD {X}";
    }
}
