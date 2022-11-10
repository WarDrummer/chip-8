// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class LDXK : MnemonicFormatter, IMnemonic
{
    internal LDXK(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return Format("LD", X, "K");
    }
}
