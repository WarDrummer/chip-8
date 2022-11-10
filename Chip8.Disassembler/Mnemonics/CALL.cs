// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class CALL : OpcodeToTextParser, IMnemonic
{
    internal CALL(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return $"CALL {NNN}";
    }
}
