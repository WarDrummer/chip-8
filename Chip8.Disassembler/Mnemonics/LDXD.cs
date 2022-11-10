// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class LDXD : MnemonicFormatter, IMnemonic
{
    internal LDXD(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return Format("LD", X, "DT");
    }
}
