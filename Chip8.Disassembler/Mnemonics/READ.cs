// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class READ : OpcodeToTextParser, IMnemonic
{
    internal READ(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return $"READ {X}";
    }
}
