// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class SHR : MnemonicFormatter, IMnemonic
{
    internal SHR(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return Format("SHR", X, Y);
    }
}
