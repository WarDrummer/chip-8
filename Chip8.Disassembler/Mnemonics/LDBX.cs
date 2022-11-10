// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class LDBX : MnemonicFormatter, IMnemonic
{
    internal LDBX(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return Format("LD", "B", X);
    }
}
