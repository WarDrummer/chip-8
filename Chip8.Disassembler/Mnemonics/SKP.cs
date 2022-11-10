// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class SKP : MnemonicFormatter, IMnemonic
{
    internal SKP(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return Format("SKP", X);
    }
}
