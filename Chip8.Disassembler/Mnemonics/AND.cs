// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class AND : MnemonicFormatter, IMnemonic
{
    internal AND(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return Format("AND", X, Y);
    }
}
