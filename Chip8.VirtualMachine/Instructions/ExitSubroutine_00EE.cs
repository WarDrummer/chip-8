// ReSharper disable InconsistentNaming

namespace Chip8.Instructions;

internal class ExitSubroutine_00EE : IInstruction
{
    public void Execute(VirtualMachine vm)
    {
        vm.PC = vm.Stack[--vm.SP & 0xF];
        vm.PC += 2;
    }
}
