// ReSharper disable InconsistentNaming

namespace Chip8.Opcodes;

internal class Ox8XY3 : OpcodeParser, IOpcode
{
    internal Ox8XY3(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        vm.V[X] = (byte)(vm.V[X] ^ vm.V[Y]);
        vm.PC += 2;
    }
}
