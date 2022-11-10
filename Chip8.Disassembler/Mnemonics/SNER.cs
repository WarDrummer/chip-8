// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class SNER : MnemonicFormatter, IMnemonic
{
    internal SNER(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return Format("SNE", X, Y);
    }
}
