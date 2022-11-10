namespace Chip8.Mnemonics;

internal class UnrecognizedOpcode : OpcodeToTextParser, IMnemonic
{
    internal UnrecognizedOpcode(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return "# Unrecognized Opcode";
    }
}
