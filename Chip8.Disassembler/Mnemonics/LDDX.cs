// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class LDDX : MnemonicFormatter, IMnemonic
{
    internal LDDX(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return Format("LD", "DT", X);
    }
}
