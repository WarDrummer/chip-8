namespace Chip8.Instructions;

internal class NoOp : OpcodeParser, IInstruction
{
    internal NoOp(ushort opcode) : base(opcode)
    {
    }

    public void Execute(VirtualMachine vm)
    {
        throw new NotImplementedException($"0x{Opcode:X4} not implemented.");
    }
}
