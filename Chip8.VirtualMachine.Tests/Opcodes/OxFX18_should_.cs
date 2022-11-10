// ReSharper disable InconsistentNaming

using Chip8.ExtensionMethods;

namespace Chip8.Opcodes;

public class OxFX18_should_
{
    [Fact]
    public void set_sound_timer_to_vx()
    {
        var opcode = OpcodeGenerator.Create("FX18");
        var opParser = OpcodeParser.From(opcode);
        
        var vm = new VirtualMachine()
            .RandomizeSoundTimer()
            .RandomizeRegisters();
        
        new OxFX18(opcode).Execute(vm);
        
        Assert.Equal(vm.V[opParser.X], vm.SoundTimer);
    }
        
    [Fact]
    public void increment_pc()
    {
        var opcode = OpcodeGenerator.Create("FX18");
        
        var vm = new VirtualMachine();
        var startingPc = vm.PC;
        
        new OxFX18(opcode).Execute(vm);
        
        Assert.Equal(startingPc + 2, vm.PC);
    }
}
