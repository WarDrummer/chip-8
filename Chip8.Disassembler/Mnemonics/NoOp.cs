namespace Chip8.Mnemonics;

internal class NoOp : OpcodeToTextParser, IMnemonic
{
    internal NoOp(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return "# Unrecognized Opcode";
    }
}
