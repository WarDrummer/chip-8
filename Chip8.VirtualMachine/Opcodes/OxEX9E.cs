// ReSharper disable InconsistentNaming

namespace Chip8.Opcodes;

internal class OxEX9E : OpcodeParser, IOpcode
{
    internal OxEX9E(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        if (vm.Keys[vm.V[X]] != 0)
        {
            vm.PC += 4;
        }
        else
        {
            vm.PC += 2;
        }
    }
}