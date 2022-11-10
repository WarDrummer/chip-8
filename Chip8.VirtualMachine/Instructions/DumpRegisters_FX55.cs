// ReSharper disable InconsistentNaming

namespace Chip8.Instructions;

internal class DumpRegisters_FX55 : OpcodeParser, IInstruction
{
    internal DumpRegisters_FX55(ushort opcode) : base(opcode)
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
