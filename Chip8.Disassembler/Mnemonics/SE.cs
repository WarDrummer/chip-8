// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class SE : MnemonicFormatter, IMnemonic
{
    internal SE(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return Format("SE", X, NN);
    }
}
