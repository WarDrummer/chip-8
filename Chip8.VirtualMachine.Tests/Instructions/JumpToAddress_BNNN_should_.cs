// ReSharper disable InconsistentNaming

using Chip8.ExtensionMethods;
using Xunit;

namespace Chip8.Instructions;

public class JumpToAddress_BNNN_should_
{
    [Fact]
    public void set_pc_to_v0_plus_NNN()
    {
        var opcode = OpcodeGenerator.Create("BNNN");
        var opParams = OpcodeParser.From(opcode);
        
        var vm = new VirtualMachine()
            .RandomizeRegisters();
        
        var startingV0 = vm.V0;

        new JumpToAddress_BNNN(opcode).Execute(vm);

        var expected = (ushort)(startingV0 + opParams.NNN);
        Assert.Equal(expected, vm.PC);
    }
}
