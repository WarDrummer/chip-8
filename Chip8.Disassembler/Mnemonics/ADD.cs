// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class ADD : MnemonicFormatter, IMnemonic
{
    internal ADD(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return Format("ADD", NN, X);
    }
}
