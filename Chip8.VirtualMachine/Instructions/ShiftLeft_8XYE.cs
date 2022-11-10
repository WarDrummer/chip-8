// ReSharper disable InconsistentNaming

namespace Chip8.Instructions;

internal class ShiftLeft_8XYE : OpcodeParser, IInstruction
{
    internal ShiftLeft_8XYE(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        vm.VF = (byte)(vm.V[X] >> 7);
        vm.V[X] <<= 1;
        vm.PC += 2;
    }
}
