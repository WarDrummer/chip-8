// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class SKUP : MnemonicFormatter, IMnemonic
{
    internal SKUP(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return Format("SKUP", X);
    }
}
