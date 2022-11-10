// ReSharper disable InconsistentNaming

using Chip8.ExtensionMethods;

namespace Chip8.Opcodes;

public class OxFX07_should_
{
    [Fact]
    public void set_vx_to_delay_timer_value()
    {
        var opcode = OpcodeGenerator.Create("FX07");
        var opParser = OpcodeParser.From(opcode);
        
        var vm = new VirtualMachine()
            .RandomizeDelayTimer();
        
        new OxFX07(opcode).Execute(vm);
        
        Assert.Equal(vm.DelayTimer, vm.V[opParser.X]);
    }
        
    [Fact]
    public void increment_pc()
    {
        var opcode = OpcodeGenerator.Create("FX07");
        
        var vm = new VirtualMachine();
        var startingPc = vm.PC;
        
        new OxFX07(opcode).Execute(vm);
        
        Assert.Equal(startingPc + 2, vm.PC);
    }
}
