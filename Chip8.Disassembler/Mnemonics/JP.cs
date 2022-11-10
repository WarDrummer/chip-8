// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class JP : MnemonicFormatter, IMnemonic
{
    internal JP(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return Format("JP", NNN);
    }
}
