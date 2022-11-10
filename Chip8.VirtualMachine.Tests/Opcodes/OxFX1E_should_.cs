// ReSharper disable InconsistentNaming

using Chip8.ExtensionMethods;
using Xunit;

namespace Chip8.Opcodes;

public class OxFX1E_should_
{
    [Fact]
    public void add_vx_to_I()
    {
        var opcode = OpcodeGenerator.Create("FX1E");
        var opParams = OpcodeParser.From(opcode);

        var vm = new VirtualMachine()
            .RandomizeRegisters();
        var startingI = vm.I;
        
        new OxFX1E(opcode).Execute(vm);
        
        Assert.Equal(vm.V[opParams.X] + startingI, vm.I);
    }
    
    [Fact]
    public void increment_pc()
    {
        var opcode = OpcodeGenerator.Create("FX1E");
        
        var vm = new VirtualMachine();
        var startingPc = vm.PC;
        
        new OxFX1E(opcode).Execute(vm);
        
        Assert.Equal(startingPc + 2, vm.PC);
    }
}
