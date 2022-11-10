// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class ADD : OpcodeToTextParser, IMnemonic
{
    internal ADD(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return $"ADD {NN}, {X}";
    }
}
