// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class ADDR : MnemonicFormatter, IMnemonic
{
    internal ADDR(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return Format("ADDR", X, Y);
    }
}
