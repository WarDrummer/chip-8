// ReSharper disable InconsistentNaming

namespace Chip8.Instructions;

internal class AssignConstant_6XNN : OpcodeParser, IInstruction
{
    internal AssignConstant_6XNN(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        vm.V[X] = NN;
        vm.PC += 2;
    }
}
