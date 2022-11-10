// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class MOVED : MnemonicFormatter, IMnemonic
{
    internal MOVED(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return Format("MOVED", X);
    }
}
