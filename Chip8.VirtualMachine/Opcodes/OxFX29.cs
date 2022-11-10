// ReSharper disable InconsistentNaming

namespace Chip8.Opcodes;

internal class OxFX29 : OpcodeParser, IOpcode
{
    internal OxFX29(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        vm.I = (ushort)(vm.V[X] * 0x5);
        vm.PC += 2;
    }
}
