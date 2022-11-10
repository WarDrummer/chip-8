// ReSharper disable InconsistentNaming

namespace Chip8.Instructions;

internal class Subtract_8XY7 : OpcodeParser, IInstruction
{
    internal Subtract_8XY7(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        var vx = vm.V[X];
        var vy = vm.V[Y];
        if (vx > vy)
            vm.VF = 0;
        else
            vm.VF = 1;
        vm.V[X] = (byte)(vy - vx);
        vm.PC += 2;
    }
}
