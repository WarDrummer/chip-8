// ReSharper disable InconsistentNaming

using Chip8.Tests.ExtensionMethods;
using Chip8.VM;
using Chip8.VM.Instructions;
using Chip8.VM.OpcodeParser;
using Xunit;

namespace Chip8.Tests.Instructions;

public class SkipOnEqualsConstant_3XNN_should_
{
    [Fact]
    public void increment_pc_twice_when_vx_equals_nn()
    {
        var opcode = OpcodeGenerator.Create("3XNN");
        var opParser = OpcodeParser.From(opcode);
        
        var vm = new VirtualMachine()
            .RandomizeRegisters();
        vm.V[opParser.X] = opParser.NN;
            
        var startingPc = vm.PC;
        
        new SkipOnEqualsConstant_3XNN(opcode).Execute(vm);
        
        Assert.Equal(startingPc + 4, vm.PC);
    }
        
    [Fact]
    public void increment_pc_once_when_vx_not_equal_to_nn()
    {
        var opcode = OpcodeGenerator.Create("3XNN");
        var opParser = OpcodeParser.From(opcode);
        
        var vm = new VirtualMachine()
            .RandomizeRegisters();
        vm.V[opParser.X] = (byte)(opParser.NN + 1);
            
        var startingPc = vm.PC;
        
        new SkipOnEqualsConstant_3XNN(opcode).Execute(vm);
        
        Assert.Equal(startingPc + 2, vm.PC);
    }
}
