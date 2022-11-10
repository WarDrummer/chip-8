// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class MOVED : OpcodeToTextParser, IMnemonic
{
    internal MOVED(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return $"MOVED {X}";
    }
}
