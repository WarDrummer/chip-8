// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class STOR : MnemonicFormatter, IMnemonic
{
    internal STOR(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return Format("STOR", X);
    }
}
