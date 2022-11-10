// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class SHL : MnemonicFormatter, IMnemonic
{
    internal SHL(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return Format("SHL", X, Y);
    }
}
