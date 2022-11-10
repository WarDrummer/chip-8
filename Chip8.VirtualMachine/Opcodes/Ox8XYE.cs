// ReSharper disable InconsistentNaming

namespace Chip8.Opcodes;

internal class Ox8XYE : OpcodeParser, IOpcode
{
    internal Ox8XYE(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        vm.VF = (byte)(vm.V[X] >> 7);
        vm.V[X] <<= 1;
        vm.PC += 2;
    }
}
