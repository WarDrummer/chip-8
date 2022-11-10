// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class LOADS : MnemonicFormatter, IMnemonic
{
    internal LOADS(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return Format("LOADS", X);
    }
}
