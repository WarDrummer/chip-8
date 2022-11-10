// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class JUMPI : OpcodeToTextParser, IMnemonic
{
    internal JUMPI(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return $"JUMPI {NNN}";
    }
}
