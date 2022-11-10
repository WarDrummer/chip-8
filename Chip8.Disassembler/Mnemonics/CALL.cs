// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class CALL : MnemonicFormatter, IMnemonic
{
    internal CALL(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return Format("CALL", NNN);
    }
}
