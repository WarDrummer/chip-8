// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class XOR : OpcodeToTextParser, IMnemonic
{
    internal XOR(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return $"XOR {X}, {Y}";
    }
}
