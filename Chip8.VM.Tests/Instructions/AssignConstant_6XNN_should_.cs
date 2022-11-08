// ReSharper disable InconsistentNaming

using Chip8.Tests.ExtensionMethods;
using Chip8.VM;
using Chip8.VM.Instructions;
using Chip8.VM.OpcodeParser;
using Xunit;

namespace Chip8.Tests.Instructions;

public class AssignConstant_6XNN_should_
{
    [Fact]
    public void set_vx_to_nn()
    {
        var opcode = OpcodeGenerator.Create("6XNN");
        var opParams = OpcodeParser.From(opcode); 
        
        var vm = new VirtualMachine()
            .RandomizeRegisters();
        
        new AssignConstant_6XNN(opcode).Execute(vm);
        
        Assert.Equal(opParams.NN, vm.V[opParams.X]);
    }
    
    [Fact]
    public void increment_pc()
    {
        var opcode = OpcodeGenerator.Create("6XNN");
        
        var vm = new VirtualMachine();
        var startingPc = vm.PC;
        
        new AssignConstant_6XNN(opcode).Execute(vm);
        
        Assert.Equal(startingPc + 2, vm.PC);
    }
}
