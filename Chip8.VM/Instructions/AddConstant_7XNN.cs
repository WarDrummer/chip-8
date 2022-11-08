// ReSharper disable InconsistentNaming

namespace Chip8.VM.Instructions;

internal class AddConstant_7XNN : OpcodeParser.OpcodeParser, IInstruction
{
    internal AddConstant_7XNN(ushort opcode) : base(opcode)
    {
    }
    
    public void Execute(VirtualMachine vm)
    {
        vm.V[X] += NN;
        vm.PC += 2;
    }
}
