// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class SNE : MnemonicFormatter, IMnemonic
{
    internal SNE(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return Format("SNE", X, NN);
    }
}
