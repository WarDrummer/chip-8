// ReSharper disable InconsistentNaming

namespace Chip8.VM.Instructions;

internal class GetDelay_FX07 : OpcodeParser.OpcodeParser, IInstruction
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
