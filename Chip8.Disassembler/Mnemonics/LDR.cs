// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class LDR : MnemonicFormatter, IMnemonic
{
    internal LDR(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return Format("LD", X, Y);
    }
}
