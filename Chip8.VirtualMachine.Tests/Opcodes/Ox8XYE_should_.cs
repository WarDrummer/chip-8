// ReSharper disable InconsistentNaming

using Xunit;

namespace Chip8.Opcodes;

public class Ox8XYE_should_
{
    [Fact]
    public void increment_pc()
    {
        var opcode = OpcodeGenerator.Create("8XYE");
    
        var vm = new VirtualMachine();
        var startingPc = vm.PC;
    
        new Ox8XYE(opcode).Execute(vm);
    
        Assert.Equal(startingPc + 2, vm.PC);
    }
}