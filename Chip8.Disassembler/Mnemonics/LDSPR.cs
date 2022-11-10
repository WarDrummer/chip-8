// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class LDSPR : MnemonicFormatter, IMnemonic
{
    internal LDSPR(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return Format("LDSPR", X);
    }
}
