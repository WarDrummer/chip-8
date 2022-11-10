// ReSharper disable InconsistentNaming

using Chip8.ExtensionMethods;
using Xunit;

namespace Chip8.Opcodes;

public class OxFX0A_should_
{
    [Fact]
    public void increment_pc_when_key_set()
    {
        var opcode = OpcodeGenerator.Create("FX0A");
    
        var vm = new VirtualMachine()
            .SetRandomKey();
        var startingPc = vm.PC;
    
        new OxFX0A(opcode).Execute(vm);
    
        Assert.Equal(startingPc + 2, vm.PC);
    }
}
