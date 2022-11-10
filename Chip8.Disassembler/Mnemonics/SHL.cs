// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class SHL : OpcodeToTextParser, IMnemonic
{
    internal SHL(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return $"SHL {X}, {Y}";
    }
}
