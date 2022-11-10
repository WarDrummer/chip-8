// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class SKNP : MnemonicFormatter, IMnemonic
{
    internal SKNP(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return Format("SKNP", X);
    }
}
