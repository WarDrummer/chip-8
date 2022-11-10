// ReSharper disable InconsistentNaming

namespace Chip8.Opcodes;

internal class OxBNNN : OpcodeParser, IOpcode
{
    internal OxBNNN(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        vm.PC = (ushort)(vm.V0 + NNN);
    }
}
