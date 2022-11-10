// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class SKRNE : OpcodeToTextParser, IMnemonic
{
    internal SKRNE(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return $"SKRNE {X}, {Y}";
    }
}
