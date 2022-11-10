// ReSharper disable InconsistentNaming

using Xunit;

namespace Chip8.Opcodes;

public class OxFX29_should_
{
    [Fact]
    public void increment_pc()
    {
        var opcode = OpcodeGenerator.Create("FX29");
    
        var vm = new VirtualMachine();
        var startingPc = vm.PC;
    
        new OxFX29(opcode).Execute(vm);
    
        Assert.Equal(startingPc + 2, vm.PC);
    }
}
