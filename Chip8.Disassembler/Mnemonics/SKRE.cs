// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class SKRE : MnemonicFormatter, IMnemonic
{
    internal SKRE(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return Format("SKRE", X, Y);
    }
}
