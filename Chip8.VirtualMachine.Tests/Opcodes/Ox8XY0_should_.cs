// ReSharper disable InconsistentNaming

using Chip8.ExtensionMethods;

namespace Chip8.Opcodes;

public class Ox8XY0_should_
{
    [Fact]
    public void assign_value_of_vx_to_vy()
    {
        var opcode = OpcodeGenerator.Create("8XY0");
        var opParams = OpcodeParser.From(opcode);
        
        var vm = new VirtualMachine()
            .RandomizeRegisters();
        
        new Ox8XY0(opcode).Execute(vm);
        
        Assert.Equal(vm.V[opParams.X], vm.V[opParams.Y]);
    }
    
    [Fact]
    public void increment_pc()
    {
        var opcode = OpcodeGenerator.Create("8XY0");
        
        var vm = new VirtualMachine();
        var startingPc = vm.PC;
        
        new Ox8XY0(opcode).Execute(vm);
        
        Assert.Equal(startingPc + 2, vm.PC);
    }
}
