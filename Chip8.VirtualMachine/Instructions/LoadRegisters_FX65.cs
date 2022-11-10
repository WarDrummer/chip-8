// ReSharper disable InconsistentNaming

namespace Chip8.Instructions;

internal class LoadRegisters_FX65 : OpcodeParser, IInstruction
{
    internal LoadRegisters_FX65(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        var I = vm.I;
        for (var register = 0; register <= X; register++)
            vm.V[register] = vm.Memory[I++];
        vm.PC += 2;
    }
}
