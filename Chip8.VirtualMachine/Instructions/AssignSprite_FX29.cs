// ReSharper disable InconsistentNaming

namespace Chip8.Instructions;

internal class AssignSprite_FX29 : OpcodeParser, IInstruction
{
    internal AssignSprite_FX29(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        vm.I = (ushort)(vm.V[X] * 0x5);
        vm.PC += 2;
    }
}
