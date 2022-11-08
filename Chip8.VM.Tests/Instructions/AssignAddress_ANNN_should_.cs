// ReSharper disable InconsistentNaming

using Chip8.Tests.ExtensionMethods;
using Chip8.VM;
using Chip8.VM.Instructions;
using Chip8.VM.OpcodeParser;
using Xunit;

namespace Chip8.Tests.Instructions;

public class AssignAddress_ANNN_should_
{
    [Fact]
    public void assign_NNN_to_I()
    {
        var opcode = OpcodeGenerator.Create("ANNN");
        var opParams = OpcodeParser.From(opcode);
        
        var vm = new VirtualMachine()
            .RandomizeI();
        
        new AssignAddress_ANNN(opcode).Execute(vm);
        
        Assert.Equal(opParams.NNN, vm.I);
    }

    [Fact]
    public void increment_pc()
    {
        var opcode = OpcodeGenerator.Create("ANNN");
        
        var vm = new VirtualMachine();
        var startingPc = vm.PC;
        
        new AssignAddress_ANNN(opcode).Execute(vm);
        
        Assert.Equal(startingPc + 2, vm.PC);
    }
}
