// ReSharper disable InconsistentNaming

namespace Chip8.VM.Instructions;

internal class PlusEquals_8XY4 : OpcodeParser.OpcodeParser, IInstruction
{
    internal PlusEquals_8XY4(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        if (vm.V[Y] > 0xFF - vm.V[X])
            vm.VF = 1;
        else
            vm.VF = 0;
        vm.V[X] = (byte)(vm.V[X] + vm.V[Y]);
        vm.PC += 2;
    }
}
