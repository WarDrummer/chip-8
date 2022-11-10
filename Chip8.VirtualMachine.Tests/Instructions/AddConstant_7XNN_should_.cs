// ReSharper disable InconsistentNaming

using Chip8.ExtensionMethods;
using Xunit;

namespace Chip8.Instructions;

public class AddConstant_7XNN_should_
{
    [Fact]
    public void add_NN_to_VX()
    {
        var opcode = OpcodeGenerator.Create("7XNN");
        var opParams = OpcodeParser.From(opcode);
        
        var vm = new VirtualMachine()
            .RandomizeRegisters();
        
        var startingVX = vm.V[opParams.X];
        
        new AddConstant_7XNN(opcode).Execute(vm);
            
        Assert.Equal((byte)(startingVX + opParams.NN), vm.V[opParams.X]);
    }
    
    [Fact]
    public void increment_pc()
    {
        var opcode = OpcodeGenerator.Create("7XNN");
        
        var vm = new VirtualMachine();
        var startingPc = vm.PC;
        
        new AddConstant_7XNN(opcode).Execute(vm);
        
        Assert.Equal(startingPc + 2, vm.PC);
    }
}
