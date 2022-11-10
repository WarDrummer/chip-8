// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class JUMP : MnemonicFormatter, IMnemonic
{
    internal JUMP(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return Format("JUMP", NNN);
    }
}
