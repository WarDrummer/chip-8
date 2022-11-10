// ReSharper disable InconsistentNaming

using Xunit;

namespace Chip8.Opcodes;

public class Ox8XY7_should_
{
    [Fact]
    public void increment_pc()
    {
        var opcode = OpcodeGenerator.Create("8XY7");
    
        var vm = new VirtualMachine();
        var startingPc = vm.PC;
    
        new Ox8XY7(opcode).Execute(vm);
    
        Assert.Equal(startingPc + 2, vm.PC);
    }
}
