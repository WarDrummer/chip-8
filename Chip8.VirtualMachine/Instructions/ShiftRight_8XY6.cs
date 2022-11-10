// ReSharper disable InconsistentNaming

namespace Chip8.Instructions;

internal class ShiftRight_8XY6 : OpcodeParser, IInstruction
{
    internal ShiftRight_8XY6(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        vm.VF = (byte)(vm.V[X] & 0x01);
        vm.V[X] >>= 1;
        vm.PC += 2;
    }
}
