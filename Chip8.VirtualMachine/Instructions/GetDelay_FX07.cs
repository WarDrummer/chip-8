// ReSharper disable InconsistentNaming

namespace Chip8.Instructions;

internal class GetDelay_FX07 : OpcodeParser, IInstruction
{
    internal GetDelay_FX07(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        vm.V[X] = vm.DelayTimer;
        vm.PC += 2;
    }
}
