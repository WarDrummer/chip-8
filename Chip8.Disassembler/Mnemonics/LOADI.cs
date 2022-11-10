// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class LOADI : OpcodeToTextParser, IMnemonic
{
    internal LOADI(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return $"LOADI {NNN}";
    }
}
