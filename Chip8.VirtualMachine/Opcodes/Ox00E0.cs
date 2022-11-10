// ReSharper disable InconsistentNaming

namespace Chip8.Opcodes;

internal class Ox00E0 : IOpcode
{
    public void Execute(VirtualMachine vm)
    {
        vm.Display.Clear();
        vm.Refresh = true;
        vm.PC += 2;
    }
}
