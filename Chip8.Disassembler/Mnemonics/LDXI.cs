// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class LDXI : MnemonicFormatter, IMnemonic
{
    internal LDXI(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return Format("LD", X, "I");
    }
}
