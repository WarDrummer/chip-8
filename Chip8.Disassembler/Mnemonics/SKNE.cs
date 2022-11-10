// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class SKNE : MnemonicFormatter, IMnemonic
{
    internal SKNE(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return Format("SKNE", X, NN);
    }
}
