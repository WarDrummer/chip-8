namespace Chip8.VM.Instructions;

internal class NoOp : OpcodeParser.OpcodeParser, IInstruction
{
    internal NoOp(ushort opcode) : base(opcode)
    {
    }

    public void Execute(VirtualMachine vm)
    {
        throw new NotImplementedException($"0x{Opcode:X4} not implemented.");
    }
}
