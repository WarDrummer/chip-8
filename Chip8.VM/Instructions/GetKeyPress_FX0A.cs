// ReSharper disable InconsistentNaming

namespace Chip8.VM.Instructions;

internal class GetKeyPress_FX0A : OpcodeParser.OpcodeParser, IInstruction
{
    internal GetKeyPress_FX0A(ushort opcode) : base(opcode)
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
