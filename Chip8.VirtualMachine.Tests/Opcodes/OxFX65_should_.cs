// ReSharper disable InconsistentNaming

namespace Chip8.Opcodes;

public class OxFX65_should_
{
    [Fact]
    public void increment_pc()
    {
        var opcode = OpcodeGenerator.Create("FX65");
    
        var vm = new VirtualMachine();
        var startingPc = vm.PC;
    
        new OxFX65(opcode).Execute(vm);
    
        Assert.Equal(startingPc + 2, vm.PC);
    }
}
