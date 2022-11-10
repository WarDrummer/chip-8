// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class SUB : MnemonicFormatter, IMnemonic
{
    internal SUB(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return Format("SUB", X, Y);
    }
}
