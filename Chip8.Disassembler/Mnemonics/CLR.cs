// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class CLR : MnemonicFormatter, IMnemonic
{
    internal CLR(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return Format("CLR");
    }
}
