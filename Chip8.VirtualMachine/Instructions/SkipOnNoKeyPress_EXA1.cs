// ReSharper disable InconsistentNaming

namespace Chip8.Instructions;

internal class SkipOnNoKeyPress_EXA1 : OpcodeParser, IInstruction
{
    internal SkipOnNoKeyPress_EXA1(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        if (vm.Keys[vm.V[X]] == 0)
        {
            vm.PC += 4;
        }
        else
        {
            vm.PC += 2;
        }
    }
}
