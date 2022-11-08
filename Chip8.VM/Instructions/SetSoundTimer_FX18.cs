// ReSharper disable InconsistentNaming

namespace Chip8.VM.Instructions;

internal class SetSoundTimer_FX18 : OpcodeParser.OpcodeParser, IInstruction
{
    internal SetSoundTimer_FX18(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        vm.SoundTimer = vm.V[X];
        vm.PC += 2;
    }
}
