// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class CLS : MnemonicFormatter, IMnemonic
{
    internal CLS(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return Format("CLS");
    }
}
