// ReSharper disable InconsistentNaming

namespace Chip8.Opcodes;

internal class Ox00EE : IOpcode
{
    public void Execute(VirtualMachine vm)
    {
        vm.PC = vm.Stack[--vm.SP & 0xF];
        vm.PC += 2;
    }
}
