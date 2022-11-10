namespace Chip8.Opcodes;

internal class UnrecognizedOpcode : OpcodeParser, IOpcode
{
    internal UnrecognizedOpcode(ushort opcode) : base(opcode)
    {
    }

    public void Execute(VirtualMachine vm)
    {
        throw new NotImplementedException($"0x{Opcode:X4} not implemented.");
    }
}
