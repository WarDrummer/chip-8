// ReSharper disable InconsistentNaming

namespace Chip8.VM.Instructions;

internal class BitwiseOr_8XY1 : OpcodeParser.OpcodeParser, IInstruction
{
    internal BitwiseOr_8XY1(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        vm.V[X] = (byte)(vm.V[X] | vm.V[Y]);
        vm.PC += 2;
    }
}
