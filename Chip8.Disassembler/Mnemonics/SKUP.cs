// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class SKUP : OpcodeToTextParser, IMnemonic
{
    internal SKUP(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return $"SKUP {X}";
    }
}
