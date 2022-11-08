// ReSharper disable InconsistentNaming

namespace Chip8.VM.Instructions;

internal class AssignBCD_FX33 : OpcodeParser.OpcodeParser, IInstruction
{
    internal AssignBCD_FX33(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        var vx = vm.V[X];
        vm.Memory[vm.I] =  (byte)(vx / 100);
        vm.Memory[vm.I + 1] = (byte)(vx / 10 % 10);
        vm.Memory[vm.I + 2] = (byte)(vx % 100 % 10);
        vm.PC += 2;
    }
}
