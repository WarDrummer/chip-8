// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class XOR : MnemonicFormatter, IMnemonic
{
    internal XOR(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return Format("XOR", X, Y);
    }
}
