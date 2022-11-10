// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class LDFX : MnemonicFormatter, IMnemonic
{
    internal LDFX(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return Format("LD", "F", X);
    }
}
