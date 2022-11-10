// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class LOADS : OpcodeToTextParser, IMnemonic
{
    internal LOADS(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return $"LOADS {X}";
    }
}
