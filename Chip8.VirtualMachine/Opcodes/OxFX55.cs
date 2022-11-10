// ReSharper disable InconsistentNaming

namespace Chip8.Opcodes;

internal class OxFX55 : OpcodeParser, IOpcode
{
    internal OxFX55(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        var I = vm.I;
        for(var register = 0; register <= X; register++)
            vm.Memory[I++] = vm.V[register];
        vm.PC += 2;
    }
}
