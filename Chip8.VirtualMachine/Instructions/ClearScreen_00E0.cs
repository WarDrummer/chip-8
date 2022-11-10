// ReSharper disable InconsistentNaming

namespace Chip8.Instructions;

internal class ClearScreen_00E0 : IInstruction
{
    public void Execute(VirtualMachine vm)
    {
        vm.Display.Clear();
        vm.PC += 2;
    }
}
