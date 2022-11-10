// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class SUBB : MnemonicFormatter, IMnemonic
{
    internal SUBB(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return Format("SUBB", X, Y);
    }
}
