// ReSharper disable InconsistentNaming

namespace Chip8.Instructions;

internal class AddToI_FX1E : OpcodeParser, IInstruction
{
    internal AddToI_FX1E(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        ushort v = (ushort)(vm.I + vm.V[X]);
           
        // Commodore Amiga ONLY
        // if(v > 0x0FFF)
        // {
        //     vm.VF = 1;
        // }
        // else
        // {
        //     vm.VF = 0;
        // }
            
        vm.I = v;
        vm.PC += 2;
    }
}
