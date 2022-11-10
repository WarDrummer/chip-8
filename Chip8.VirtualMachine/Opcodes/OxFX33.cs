// ReSharper disable InconsistentNaming

namespace Chip8.Opcodes;

internal class OxFX33 : OpcodeParser, IOpcode
{
    internal OxFX33(ushort opcode) : base(opcode)
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
