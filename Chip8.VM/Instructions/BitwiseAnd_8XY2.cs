// ReSharper disable InconsistentNaming

namespace Chip8.VM.Instructions;

internal class BitwiseAnd_8XY2 : OpcodeParser.OpcodeParser, IInstruction
{
    internal BitwiseAnd_8XY2(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        vm.V[X] = (byte)(vm.V[X] & vm.V[Y]);
        vm.PC += 2;
    }
}
