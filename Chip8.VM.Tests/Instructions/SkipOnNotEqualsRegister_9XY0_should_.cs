// ReSharper disable InconsistentNaming

using Chip8.Tests.ExtensionMethods;
using Chip8.VM;
using Chip8.VM.Instructions;
using Chip8.VM.OpcodeParser;
using Xunit;

namespace Chip8.Tests.Instructions;

public class SkipOnNotEqualsRegister_9XY0_should_
{
    [Fact]
    public void increment_pc_twice_when_vx_not_equal_to_vy()
    {
        var opcode = OpcodeGenerator.Create("9XY0");
        var opParser = OpcodeParser.From(opcode);
        
        var vm = new VirtualMachine()
            .RandomizeRegisters();
        
        vm.V[opParser.X] = (byte)(vm.V[opParser.Y] + 1);

        var startingPc = vm.PC;
        
        new SkipOnNotEqualsRegister_9XY0(opcode).Execute(vm);
        
        Assert.Equal(startingPc + 4, vm.PC);
    }
        
    [Fact]
    public void increment_pc_once_when_vx_equals_vy()
    {
        var opcode = OpcodeGenerator.Create("9XY0");
        var opParser = OpcodeParser.From(opcode);
        
        var vm = new VirtualMachine()
            .RandomizeRegisters();
        vm.V[opParser.X] = vm.V[opParser.Y];
            
        var startingPc = vm.PC;
        
        new SkipOnNotEqualsRegister_9XY0(opcode).Execute(vm);
        
        Assert.Equal(startingPc + 2, vm.PC);
    }
}
