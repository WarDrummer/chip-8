// ReSharper disable InconsistentNaming

namespace Chip8.Opcodes;

public class Ox1NNN_should_
{
    [Fact]
    public void set_pc_to_nnn()
    {
        var opcode = OpcodeGenerator.Create("1NNN");
        var opcodeParams = OpcodeParser.From(opcode);
        var instruction = new Ox1NNN(opcode);
        var vm = new VirtualMachine();
        
        instruction.Execute(vm);
        
        Assert.Equal(opcodeParams.NNN, vm.PC);
    }
}
