// ReSharper disable InconsistentNaming

namespace Chip8.VM.Instructions;

internal class JumpToAddress_1NNN : OpcodeParser.OpcodeParser, IInstruction
{
    internal JumpToAddress_1NNN(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        vm.PC = NNN;
    }
}
