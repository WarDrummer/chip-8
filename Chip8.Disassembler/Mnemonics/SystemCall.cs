// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class SystemCall : OpcodeToTextParser, IMnemonic
{
    internal SystemCall(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return "# System Call (ignored)";
    }
}
