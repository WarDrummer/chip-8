// ReSharper disable InconsistentNaming

namespace Chip8.Instructions;

internal class BitwiseXor_8XY3 : OpcodeParser, IInstruction
{
    internal BitwiseXor_8XY3(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        vm.V[X] = (byte)(vm.V[X] ^ vm.V[Y]);
        vm.PC += 2;
    }
}
