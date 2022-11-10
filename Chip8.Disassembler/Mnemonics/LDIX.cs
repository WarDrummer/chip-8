// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class LDIX : MnemonicFormatter, IMnemonic
{
    internal LDIX(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return Format("LD", "I", X);
    }
}
