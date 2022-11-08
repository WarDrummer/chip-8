// ReSharper disable InconsistentNaming

namespace Chip8.VM.Instructions;

internal class EnterSubroutine_2NNN : OpcodeParser.OpcodeParser, IInstruction
{
    internal EnterSubroutine_2NNN(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        vm.Stack[vm.SP & 0xF] = vm.PC;
        vm.SP += 1;
        vm.PC = NNN;
    }
}
