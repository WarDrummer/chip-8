// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class RAND : MnemonicFormatter, IMnemonic
{
    private static readonly Random _random = new ();
    
    internal RAND(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return Format("RAND", X, NN);
    }
}
