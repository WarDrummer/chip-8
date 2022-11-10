// ReSharper disable InconsistentNaming

namespace Chip8.Opcodes;

internal class Ox4XNN : OpcodeParser, IOpcode
{
    internal Ox4XNN(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        if (vm.V[X] != NN)
        {
            vm.PC += 4;
        }
        else
        {
            vm.PC += 2;
        }
    }
}
