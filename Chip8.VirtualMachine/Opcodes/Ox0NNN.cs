// ReSharper disable InconsistentNaming

namespace Chip8.Opcodes;

internal class Ox0NNN : OpcodeParser, IOpcode
{
    internal Ox0NNN(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        throw new NotImplementedException($"0x{Opcode:X4} not implemented.");
    }
}
