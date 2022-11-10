// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class LOADD : OpcodeToTextParser, IMnemonic
{
    internal LOADD(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return $"LOADD {X}";
    }
}
