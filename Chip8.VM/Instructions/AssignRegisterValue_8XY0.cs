// ReSharper disable InconsistentNaming

namespace Chip8.VM.Instructions;

internal class AssignRegisterValue_8XY0 : OpcodeParser.OpcodeParser, IInstruction
{
    internal AssignRegisterValue_8XY0(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        vm.V[X] = vm.V[Y];
        vm.PC += 2;
    }
}
