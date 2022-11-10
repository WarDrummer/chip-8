// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class DRW : MnemonicFormatter, IMnemonic
{
    internal DRW(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return Format("DRW", X, Y, N);
    }
}
