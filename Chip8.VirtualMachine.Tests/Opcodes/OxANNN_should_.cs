// ReSharper disable InconsistentNaming

using Chip8.ExtensionMethods;
using Xunit;

namespace Chip8.Opcodes;

public class OxANNN_should_
{
    [Fact]
    public void assign_NNN_to_I()
    {
        var opcode = OpcodeGenerator.Create("ANNN");
        var opParams = OpcodeParser.From(opcode);
        
        var vm = new VirtualMachine()
            .RandomizeI();
        
        new OxANNN(opcode).Execute(vm);
        
        Assert.Equal(opParams.NNN, vm.I);
    }

    [Fact]
    public void increment_pc()
    {
        var opcode = OpcodeGenerator.Create("ANNN");
        
        var vm = new VirtualMachine();
        var startingPc = vm.PC;
        
        new OxANNN(opcode).Execute(vm);
        
        Assert.Equal(startingPc + 2, vm.PC);
    }
}
