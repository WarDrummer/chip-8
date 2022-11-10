// ReSharper disable InconsistentNaming

namespace Chip8.Opcodes;

internal class OxFX1E : OpcodeParser, IOpcode
{
    internal OxFX1E(ushort opcode) : base(opcode)
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
