// ReSharper disable InconsistentNaming

namespace Chip8.Opcodes;

internal class OxFX65 : OpcodeParser, IOpcode
{
    internal OxFX65(ushort opcode) : base(opcode)
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
