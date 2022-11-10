// ReSharper disable InconsistentNaming

namespace Chip8.Opcodes;

internal class Ox7XNN : OpcodeParser, IOpcode
{
    internal Ox7XNN(ushort opcode) : base(opcode)
    {
    }
    
    public void Execute(VirtualMachine vm)
    {
        vm.V[X] += NN;
        vm.PC += 2;
    }
}
