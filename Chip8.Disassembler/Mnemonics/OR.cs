// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class OR : MnemonicFormatter, IMnemonic
{
    internal OR(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return Format("OR", X, Y);
    }
}
