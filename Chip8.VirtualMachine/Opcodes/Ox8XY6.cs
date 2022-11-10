// ReSharper disable InconsistentNaming

namespace Chip8.Opcodes;

internal class Ox8XY6 : OpcodeParser, IOpcode
{
    internal Ox8XY6(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        vm.VF = (byte)(vm.V[X] & 0x01);
        vm.V[X] >>= 1;
        vm.PC += 2;
    }
}
