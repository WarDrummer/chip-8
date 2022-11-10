// ReSharper disable InconsistentNaming

namespace Chip8.Opcodes;

internal class Ox8XY5 : OpcodeParser, IOpcode
{
    internal Ox8XY5(ushort opcode) : base(opcode)
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
