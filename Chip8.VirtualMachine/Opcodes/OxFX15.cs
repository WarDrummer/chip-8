// ReSharper disable InconsistentNaming

namespace Chip8.Opcodes;

internal class OxFX15 : OpcodeParser, IOpcode
{
    internal OxFX15(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        vm.DelayTimer = vm.V[X];
        vm.PC += 2;
    }
}
