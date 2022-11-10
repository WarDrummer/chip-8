// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class LOAD : OpcodeToTextParser, IMnemonic
{
    internal LOAD(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return $"LOAD {X}, {NN}";
    }
}
