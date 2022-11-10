// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class SKE : OpcodeToTextParser, IMnemonic
{
    internal SKE(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return $"SKE {X}, {NN}";
    }
}
