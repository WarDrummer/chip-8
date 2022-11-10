// ReSharper disable InconsistentNaming

using Chip8.ExtensionMethods;
using Xunit;

namespace Chip8.Instructions;

public class SetDelayTimer_FX15_should_
{
    [Fact]
    public void set_delay_timer_to_vx()
    {
        var opcode = OpcodeGenerator.Create("FX15");
        var opParser = OpcodeParser.From(opcode);
        
        var vm = new VirtualMachine()
            .RandomizeDelayTimer()
            .RandomizeRegisters();
        
        new SetDelayTimer_FX15(opcode).Execute(vm);
        
        Assert.Equal(vm.V[opParser.X], vm.DelayTimer);
    }
        
    [Fact]
    public void increment_pc()
    {
        var opcode = OpcodeGenerator.Create("FX15");
        
        var vm = new VirtualMachine();
        var startingPc = vm.PC;
        
        new SetDelayTimer_FX15(opcode).Execute(vm);
        
        Assert.Equal(startingPc + 2, vm.PC);
    }
}
