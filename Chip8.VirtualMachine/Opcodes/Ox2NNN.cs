// ReSharper disable InconsistentNaming

namespace Chip8.Opcodes;

internal class Ox2NNN : OpcodeParser, IOpcode
{
    internal Ox2NNN(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        vm.Stack[vm.SP & 0xF] = vm.PC;
        vm.SP += 1;
        vm.PC = NNN;
    }
}
