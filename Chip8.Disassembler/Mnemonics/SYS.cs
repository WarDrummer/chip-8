// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class SYS : MnemonicFormatter, IMnemonic
{
    internal SYS(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return Format("SYS", NNN);
    }
}
