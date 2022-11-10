// ReSharper disable InconsistentNaming

namespace Chip8.Opcodes;

internal class Ox3XNN : OpcodeParser, IOpcode
{
    internal Ox3XNN(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        if (vm.V[X] == NN)
        {
            vm.PC += 4;
        }
        else 
        {
            vm.PC += 2;
        }
    }
}
