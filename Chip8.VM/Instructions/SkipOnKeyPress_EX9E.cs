// ReSharper disable InconsistentNaming

namespace Chip8.VM.Instructions;

internal class SkipOnKeyPress_EX9E : OpcodeParser.OpcodeParser, IInstruction
{
    internal SkipOnKeyPress_EX9E(ushort opcode) : base(opcode)
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
