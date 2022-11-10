// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class JUMPI : MnemonicFormatter, IMnemonic
{
    internal JUMPI(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return Format("JUMPI", NNN);
    }
}
