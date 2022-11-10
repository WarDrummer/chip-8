// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class ADDI : MnemonicFormatter, IMnemonic
{
    internal ADDI(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return Format("ADD", "I", X);
    }
}
