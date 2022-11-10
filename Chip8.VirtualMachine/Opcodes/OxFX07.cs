// ReSharper disable InconsistentNaming

namespace Chip8.Opcodes;

internal class OxFX07 : OpcodeParser, IOpcode
{
    internal OxFX07(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        vm.V[X] = vm.DelayTimer;
        vm.PC += 2;
    }
}
