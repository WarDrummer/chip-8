// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class LOAD : MnemonicFormatter, IMnemonic
{
    internal LOAD(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return Format("LOAD", X, NN);
    }
}
