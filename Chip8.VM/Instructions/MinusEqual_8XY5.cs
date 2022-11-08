// ReSharper disable InconsistentNaming

namespace Chip8.VM.Instructions;

internal class MinusEqual_8XY5 : OpcodeParser.OpcodeParser, IInstruction
{
    internal MinusEqual_8XY5(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        if (vm.V[Y] > vm.V[X])
            vm.VF = 0;
        else
            vm.VF = 1;
        vm.V[X] = (byte)(vm.V[X] - vm.V[Y]);
        vm.PC += 2;
    }
}
