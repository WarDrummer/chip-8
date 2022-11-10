// ReSharper disable InconsistentNaming

using Chip8.ExtensionMethods;
using Xunit;

namespace Chip8.Instructions;

public class GetDelay_FX07_should_
{
    [Fact]
    public void set_vx_to_delay_timer_value()
    {
        var opcode = OpcodeGenerator.Create("FX07");
        var opParser = OpcodeParser.From(opcode);
        
        var vm = new VirtualMachine()
            .RandomizeDelayTimer();
        
        new GetDelay_FX07(opcode).Execute(vm);
        
        Assert.Equal(vm.DelayTimer, vm.V[opParser.X]);
    }
        
    [Fact]
    public void increment_pc()
    {
        var opcode = OpcodeGenerator.Create("FX07");
        
        var vm = new VirtualMachine();
        var startingPc = vm.PC;
        
        new GetDelay_FX07(opcode).Execute(vm);
        
        Assert.Equal(startingPc + 2, vm.PC);
    }
}
