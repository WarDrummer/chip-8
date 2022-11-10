// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class RET : MnemonicFormatter, IMnemonic
{
    internal RET(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return Format("RET");
    }
}
