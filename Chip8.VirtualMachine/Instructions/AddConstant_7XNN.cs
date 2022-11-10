// ReSharper disable InconsistentNaming

namespace Chip8.Instructions;

internal class AddConstant_7XNN : OpcodeParser, IInstruction
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
