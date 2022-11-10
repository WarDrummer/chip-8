// ReSharper disable InconsistentNaming

using Chip8.ExtensionMethods;
using Xunit;

namespace Chip8.Instructions;

public class BitwiseXor_8XY3_should_
{
    [Fact]
    public void set_vx_to_bitwise_and_of_vx_and_vy()
    {
        var opcode = OpcodeGenerator.Create("8XY3");
        var opParams = OpcodeParser.From(opcode);
        
        var vm = new VirtualMachine()
            .RandomizeRegisters();
        
        var startingVx = vm.V[opParams.X];
        var startingVy = vm.V[opParams.Y];
        
        new BitwiseXor_8XY3(opcode).Execute(vm);
        
        Assert.Equal(startingVx ^ startingVy, vm.V[opParams.X]);
    }
    
    [Fact]
    public void increment_pc()
    {
        var opcode = OpcodeGenerator.Create("8XY3");
        
        var vm = new VirtualMachine();
        var startingPc = vm.PC;
        
        new BitwiseXor_8XY3(opcode).Execute(vm);
        
        Assert.Equal(startingPc + 2, vm.PC);
    }
}
