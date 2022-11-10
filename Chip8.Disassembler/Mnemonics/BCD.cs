// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class BCD : MnemonicFormatter, IMnemonic
{
    internal BCD(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return Format("BCD", X);
    }
}
