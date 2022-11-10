// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class RTS : MnemonicFormatter, IMnemonic
{
    internal RTS(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return Format("RTS");
    }
}
