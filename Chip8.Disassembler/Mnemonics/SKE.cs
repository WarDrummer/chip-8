// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class SKE : MnemonicFormatter, IMnemonic
{
    internal SKE(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return Format("SKE", X, NN);
    }
}
