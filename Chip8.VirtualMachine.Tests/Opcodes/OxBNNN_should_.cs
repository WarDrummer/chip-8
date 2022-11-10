// ReSharper disable InconsistentNaming

using Chip8.ExtensionMethods;
using Xunit;

namespace Chip8.Opcodes;

public class OxBNNN_should_
{
    [Fact]
    public void set_pc_to_v0_plus_NNN()
    {
        var opcode = OpcodeGenerator.Create("BNNN");
        var opParams = OpcodeParser.From(opcode);
        
        var vm = new VirtualMachine()
            .RandomizeRegisters();
        
        var startingV0 = vm.V0;

        new OxBNNN(opcode).Execute(vm);

        var expected = (ushort)(startingV0 + opParams.NNN);
        Assert.Equal(expected, vm.PC);
    }
}
