// ReSharper disable InconsistentNaming

namespace Chip8.VM.Instructions;

internal class JumpToAddress_BNNN : OpcodeParser.OpcodeParser, IInstruction
{
    internal JumpToAddress_BNNN(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        vm.PC = (ushort)(vm.V0 + NNN);
    }
}
