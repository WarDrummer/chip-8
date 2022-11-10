// ReSharper disable InconsistentNaming

namespace Chip8.Opcodes;

internal class OxEXA1 : OpcodeParser, IOpcode
{
    internal OxEXA1(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        if (vm.Keys[vm.V[X]] == 0)
        {
            vm.PC += 4;
        }
        else
        {
            vm.PC += 2;
        }
    }
}
