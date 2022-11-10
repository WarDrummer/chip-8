// ReSharper disable InconsistentNaming

namespace Chip8.Instructions;

internal class SkipOnEqualsRegister_5XY0 : OpcodeParser, IInstruction
{
    internal SkipOnEqualsRegister_5XY0(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        if (vm.V[X] == vm.V[Y])
        {
            vm.PC += 4;
        }
        else
        {
            vm.PC += 2;
        }
    }
}
