// ReSharper disable InconsistentNaming

namespace Chip8.VM.Instructions;

internal class SkipOnEqualsConstant_3XNN : OpcodeParser.OpcodeParser, IInstruction
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
