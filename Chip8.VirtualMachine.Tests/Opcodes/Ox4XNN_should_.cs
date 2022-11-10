// ReSharper disable InconsistentNaming

using Chip8.ExtensionMethods;
using Xunit;

namespace Chip8.Opcodes;

public class Ox4XNN_should_
{
    [Fact]
    public void increment_pc_twice_when_vx_not_equal_to_nn()
    {
        var opcode = OpcodeGenerator.Create("4XNN");
        var opParser = OpcodeParser.From(opcode);
        
        var vm = new VirtualMachine()
            .RandomizeRegisters();
            
        vm.V[opParser.X] = (byte)(opParser.NN + 1);
            
        var startingPc = vm.PC;
        
        new Ox4XNN(opcode).Execute(vm);
        
        Assert.Equal(startingPc + 4, vm.PC);
    }
        
    [Fact]
    public void increment_pc_once_when_vx_equals_nn()
    {
        var opcode = OpcodeGenerator.Create("4XNN");
        var opParser = OpcodeParser.From(opcode);
        
        var vm = new VirtualMachine()
            .RandomizeRegisters();
            
        vm.V[opParser.X] = opParser.NN;
        var startingPc = vm.PC;
        
        new Ox4XNN(opcode).Execute(vm);
        
        Assert.Equal(startingPc + 2, vm.PC);
    }
}
