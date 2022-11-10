// ReSharper disable InconsistentNaming

namespace Chip8.Opcodes;

public class OxDXYN_should_
{
    [Fact]
    public void increment_pc()
    {
        var opcode = OpcodeGenerator.Create("DXYN");
    
        var vm = new VirtualMachine();
        var startingPc = vm.PC;
    
        new OxDXYN(opcode).Execute(vm);
    
        Assert.Equal(startingPc + 2, vm.PC);
    }
}
