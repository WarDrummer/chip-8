// ReSharper disable InconsistentNaming

namespace Chip8.Instructions;

internal class JumpToAddress_BNNN : OpcodeParser, IInstruction
{
    internal JumpToAddress_BNNN(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        vm.PC = (ushort)(vm.V0 + NNN);
    }
}
