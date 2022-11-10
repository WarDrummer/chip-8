// ReSharper disable InconsistentNaming

namespace Chip8.Opcodes;

internal class Ox5XY0 : OpcodeParser, IOpcode
{
    internal Ox5XY0(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        if (vm.V[X] == vm.V[Y])
        {
            vm.PC += 4;
        }
        else
        {
            vm.PC += 2;
        }
    }
}
