// ReSharper disable InconsistentNaming

using Chip8.ExtensionMethods;
using Xunit;

namespace Chip8.Opcodes;

public class Ox6XNN_should_
{
    [Fact]
    public void set_vx_to_nn()
    {
        var opcode = OpcodeGenerator.Create("6XNN");
        var opParams = OpcodeParser.From(opcode); 
        
        var vm = new VirtualMachine()
            .RandomizeRegisters();
        
        new Ox6XNN(opcode).Execute(vm);
        
        Assert.Equal(opParams.NN, vm.V[opParams.X]);
    }
    
    [Fact]
    public void increment_pc()
    {
        var opcode = OpcodeGenerator.Create("6XNN");
        
        var vm = new VirtualMachine();
        var startingPc = vm.PC;
        
        new Ox6XNN(opcode).Execute(vm);
        
        Assert.Equal(startingPc + 2, vm.PC);
    }
}
