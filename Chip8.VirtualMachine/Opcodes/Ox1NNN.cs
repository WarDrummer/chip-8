// ReSharper disable InconsistentNaming

namespace Chip8.Opcodes;

internal class Ox1NNN : OpcodeParser, IOpcode
{
    internal Ox1NNN(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        vm.PC = NNN;
    }
}
