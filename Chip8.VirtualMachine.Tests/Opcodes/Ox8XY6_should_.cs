// ReSharper disable InconsistentNaming

namespace Chip8.Opcodes;

public class Ox8XY6_should_
{
    [Fact]
    public void increment_pc()
    {
        var opcode = OpcodeGenerator.Create("8XY6");
    
        var vm = new VirtualMachine();
        var startingPc = vm.PC;
    
        new Ox8XY6(opcode).Execute(vm);
    
        Assert.Equal(startingPc + 2, vm.PC);
    }
}
