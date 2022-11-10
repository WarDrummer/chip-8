// ReSharper disable InconsistentNaming

using Xunit;

namespace Chip8.Opcodes;

public class OxFX55_should_
{
    [Fact]
    public void increment_pc()
    {
        var opcode = OpcodeGenerator.Create("FX55");
    
        var vm = new VirtualMachine();
        var startingPc = vm.PC;
    
        new OxFX55(opcode).Execute(vm);
    
        Assert.Equal(startingPc + 2, vm.PC);
    }
}
