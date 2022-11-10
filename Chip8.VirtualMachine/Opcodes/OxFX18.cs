// ReSharper disable InconsistentNaming

namespace Chip8.Opcodes;

internal class OxFX18 : OpcodeParser, IOpcode
{
    internal OxFX18(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        vm.SoundTimer = vm.V[X];
        vm.PC += 2;
    }
}
