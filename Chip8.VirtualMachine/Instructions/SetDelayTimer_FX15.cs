// ReSharper disable InconsistentNaming

namespace Chip8.Instructions;

internal class SetDelayTimer_FX15 : OpcodeParser, IInstruction
{
    internal SetDelayTimer_FX15(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        vm.DelayTimer = vm.V[X];
        vm.PC += 2;
    }
}
