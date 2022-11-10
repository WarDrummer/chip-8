// ReSharper disable InconsistentNaming

using Chip8.ExtensionMethods;

namespace Chip8.Opcodes;

public class Ox8XY1_should_
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
        
        new Ox8XY1(opcode).Execute(vm);
        
        Assert.Equal(startingVx | startingVy, vm.V[opParams.X]);
    }
    
    [Fact]
    public void increment_pc()
    {
        var opcode = OpcodeGenerator.Create("8XY1");
        
        var vm = new VirtualMachine();
        var startingPc = vm.PC;
        
        new Ox8XY1(opcode).Execute(vm);
        
        Assert.Equal(startingPc + 2, vm.PC);
    }
}
