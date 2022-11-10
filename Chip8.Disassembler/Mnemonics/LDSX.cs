// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class LDSX : MnemonicFormatter, IMnemonic
{
    internal LDSX(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return Format("LD", "ST", X);
    }
}
