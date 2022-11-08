// ReSharper disable InconsistentNaming

using Chip8.Tests.ExtensionMethods;
using Chip8.VM;
using Chip8.VM.Instructions;
using Chip8.VM.OpcodeParser;
using Xunit;

namespace Chip8.Tests.Instructions;

public class BitwiseOr_8XY1_should_
{
    [Fact]
    public void set_vx_to_bitwise_and_of_vx_and_vy()
    {
        var opcode = OpcodeGenerator.Create("8XY1");
        var opParams = OpcodeParser.From(opcode);
        
        var vm = new VirtualMachine()
            .RandomizeRegisters();
        
        var startingVx = vm.V[opParams.X];
        var startingVy = vm.V[opParams.Y];
        
        new BitwiseOr_8XY1(opcode).Execute(vm);
        
        Assert.Equal(startingVx | startingVy, vm.V[opParams.X]);
    }
    
    [Fact]
    public void increment_pc()
    {
        var opcode = OpcodeGenerator.Create("8XY1");
        
        var vm = new VirtualMachine();
        var startingPc = vm.PC;
        
        new BitwiseOr_8XY1(opcode).Execute(vm);
        
        Assert.Equal(startingPc + 2, vm.PC);
    }
}
