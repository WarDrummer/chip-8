// ReSharper disable InconsistentNaming

namespace Chip8.Opcodes;

public class Ox8XY4_should_
{
    [Fact]
    public void increment_pc()
    {
        var opcode = OpcodeGenerator.Create("8XY4");
    
        var vm = new VirtualMachine();
        var startingPc = vm.PC;
    
        new Ox8XY4(opcode).Execute(vm);
    
        Assert.Equal(startingPc + 2, vm.PC);
    }
}
