// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class KEYD : MnemonicFormatter, IMnemonic
{
    internal KEYD(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return Format("KEYD", X);
    }
}
