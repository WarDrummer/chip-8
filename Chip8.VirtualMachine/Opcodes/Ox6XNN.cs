// ReSharper disable InconsistentNaming

namespace Chip8.Opcodes;

internal class Ox6XNN : OpcodeParser, IOpcode
{
    internal Ox6XNN(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        vm.V[X] = NN;
        vm.PC += 2;
    }
}
