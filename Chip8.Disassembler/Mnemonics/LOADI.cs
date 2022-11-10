// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class LOADI : MnemonicFormatter, IMnemonic
{
    internal LOADI(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return Format("LOADI", NNN);
    }
}
