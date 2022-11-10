// ReSharper disable InconsistentNaming

namespace Chip8.Opcodes;

internal class OxANNN : OpcodeParser, IOpcode
{
    internal OxANNN(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        vm.I = NNN;
        vm.PC += 2;
    }
}
