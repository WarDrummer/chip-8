// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class LDI : MnemonicFormatter, IMnemonic
{
    internal LDI(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return Format("LD", "I", NNN);
    }
}
