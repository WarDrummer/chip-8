// ReSharper disable InconsistentNaming

namespace Chip8.Opcodes;

internal class OxFX0A : OpcodeParser, IOpcode
{
    internal OxFX0A(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        for(byte key = 0; key < vm.Keys.Length; key++)
        {
            if (vm.Keys[key] != 0)
            {
                vm.V[X] = key;
                vm.PC += 2;
                break;
            }
        }
    }
}
