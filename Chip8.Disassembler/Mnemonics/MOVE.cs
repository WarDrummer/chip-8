// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class MOVE : MnemonicFormatter, IMnemonic
{
    internal MOVE(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return Format("MOVE", X, Y);
    }
}
