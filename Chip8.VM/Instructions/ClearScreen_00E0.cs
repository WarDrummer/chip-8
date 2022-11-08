// ReSharper disable InconsistentNaming

namespace Chip8.VM.Instructions;

internal class ClearScreen_00E0 : IInstruction
{
    public void Execute(VirtualMachine vm)
    {
        vm.Display.Clear();
        vm.PC += 2;
    }
}
