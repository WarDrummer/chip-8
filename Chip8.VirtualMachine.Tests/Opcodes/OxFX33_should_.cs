// ReSharper disable InconsistentNaming

using Xunit;

namespace Chip8.Opcodes;

public class OxFX33_should_
{
    [Fact]
    public void increment_pc()
    {
        var opcode = OpcodeGenerator.Create("FX33");
    
        var vm = new VirtualMachine();
        var startingPc = vm.PC;
    
        new OxFX33(opcode).Execute(vm);
    
        Assert.Equal(startingPc + 2, vm.PC);
    }
}
