// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class LOADD : MnemonicFormatter, IMnemonic
{
    internal LOADD(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return Format("LOADD", X);
    }
}
