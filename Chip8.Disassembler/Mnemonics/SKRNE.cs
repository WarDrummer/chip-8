// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class SKRNE : MnemonicFormatter, IMnemonic
{
    internal SKRNE(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return Format("SKRNE", X, Y);
    }
}
