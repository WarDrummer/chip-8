// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class SKNE : OpcodeToTextParser, IMnemonic
{
    internal SKNE(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return $"SKNE {X}, {NN}";
    }
}
