// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class JUMP : OpcodeToTextParser, IMnemonic
{
    internal JUMP(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return $"JUMP {NNN}";
    }
}
