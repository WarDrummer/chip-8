// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class DRAW : MnemonicFormatter, IMnemonic
{
    internal DRAW(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return Format("DRAW", X, Y, N);
    }
}
