// ReSharper disable InconsistentNaming

namespace Chip8.VM.Instructions;

internal class AssignAddress_ANNN : OpcodeParser.OpcodeParser, IInstruction
{
    internal AssignAddress_ANNN(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        vm.I = NNN;
        vm.PC += 2;
    }
}
