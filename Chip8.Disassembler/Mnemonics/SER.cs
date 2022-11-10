// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class SER : MnemonicFormatter, IMnemonic
{
    internal SER(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return Format("SE", X, Y);
    }
}
