// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class RND : MnemonicFormatter, IMnemonic
{
    private static readonly Random _random = new ();
    
    internal RND(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return Format("RND", X, NN);
    }
}
