// ReSharper disable InconsistentNaming

namespace Chip8.VM.Instructions;

internal class CallMachineCode_0NNN : OpcodeParser.OpcodeParser, IInstruction
{
    internal CallMachineCode_0NNN(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        throw new NotImplementedException($"0x{Opcode:X4} not implemented.");
    }
}
