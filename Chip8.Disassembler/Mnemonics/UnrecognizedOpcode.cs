namespace Chip8.Mnemonics;

internal class UnrecognizedOpcode : MnemonicFormatter, IMnemonic
{
    internal UnrecognizedOpcode(ushort opcode) : base(opcode)
    {
    }
    
    public string Disassemble()
    {
        return "# Unrecognized Opcode";
    }
}
