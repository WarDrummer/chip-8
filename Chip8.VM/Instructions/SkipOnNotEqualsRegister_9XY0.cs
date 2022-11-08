// ReSharper disable InconsistentNaming

namespace Chip8.VM.Instructions;

internal class SkipOnNotEqualsRegister_9XY0 : OpcodeParser.OpcodeParser, IInstruction
{
    internal SkipOnNotEqualsRegister_9XY0(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        if (vm.V[X] != vm.V[Y])
        {
            vm.PC += 4;
        }
        else
        {
            vm.PC += 2;
        }
    }
}
