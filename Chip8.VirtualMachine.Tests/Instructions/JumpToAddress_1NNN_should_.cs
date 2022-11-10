// ReSharper disable InconsistentNaming

using Xunit;

namespace Chip8.Instructions;

public class JumpToAddress_1NNN_should_
{
    [Fact]
    public void set_pc_to_nnn()
    {
        var opcode = OpcodeGenerator.Create("1NNN");
        var opcodeParams = OpcodeParser.From(opcode);
        var instruction = new JumpToAddress_1NNN(opcode);
        var vm = new VirtualMachine();
        
        instruction.Execute(vm);
        
        Assert.Equal(opcodeParams.NNN, vm.PC);
    }
}
