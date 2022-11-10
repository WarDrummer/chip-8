// ReSharper disable InconsistentNaming

namespace Chip8.Instructions;

internal class SkipOnEqualsConstant_3XNN : OpcodeParser, IInstruction
{
    internal SkipOnEqualsConstant_3XNN(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        if (vm.V[X] == NN)
        {
            vm.PC += 4;
        }
        else 
        {
            vm.PC += 2;
        }
    }
}
