// ReSharper disable InconsistentNaming

namespace Chip8.Opcodes;

public class OxCXNN_should_
{
    [Fact]
    public void increment_pc()
    {
        var opcode = OpcodeGenerator.Create("CXNN");
    
        var vm = new VirtualMachine();
        var startingPc = vm.PC;
    
        new OxCXNN(opcode).Execute(vm);
    
        Assert.Equal(startingPc + 2, vm.PC);
    }
}
