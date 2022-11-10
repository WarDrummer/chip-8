// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class LD : MnemonicFormatter, IMnemonic
{
    internal LD(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return Format("LD", X, NN);
    }
}
