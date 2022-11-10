// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class SUBN : MnemonicFormatter, IMnemonic
{
    internal SUBN(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return Format("SUBN", X, Y);
    }
}
