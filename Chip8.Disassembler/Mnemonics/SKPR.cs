// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class SKPR : MnemonicFormatter, IMnemonic
{
    internal SKPR(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return Format("SKPR", X);
    }
}
