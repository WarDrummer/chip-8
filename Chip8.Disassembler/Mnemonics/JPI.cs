// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class JPI : MnemonicFormatter, IMnemonic
{
    internal JPI(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return Format("JP", "V0", NNN);
    }
}
