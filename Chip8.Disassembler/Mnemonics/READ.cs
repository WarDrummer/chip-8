// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class READ : MnemonicFormatter, IMnemonic
{
    internal READ(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return Format("READ", X);
    }
}
