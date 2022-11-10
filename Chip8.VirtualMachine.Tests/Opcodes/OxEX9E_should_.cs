// ReSharper disable InconsistentNaming

using Chip8.ExtensionMethods;
using Xunit;

namespace Chip8.Opcodes;

public class OxEX9E_should_
{
    [Fact]
    public void increment_pc_twice_when_key_at_vx_set()
    {
        var opcode = OpcodeGenerator.Create("EX9E");
        var opParser = OpcodeParser.From(opcode);
        
        var vm = new VirtualMachine()
            .RandomizeRegisters(maxValue: 0xF)
            .RandomizeKeys();
        
        vm.Keys[vm.V[opParser.X]] = 1;
            
        var startingPc = vm.PC;
        
        new OxEX9E(opcode).Execute(vm);
        
        Assert.Equal(startingPc + 4, vm.PC);
    }
        
    [Fact]
    public void increment_pc_one_when_key_at_vx_not_set()
    {
        var opcode = OpcodeGenerator.Create("EX9E");
        var opParser = OpcodeParser.From(opcode);
        
        var vm = new VirtualMachine()
            .RandomizeRegisters(maxValue: 0xF)
            .RandomizeKeys();
        
        vm.Keys[vm.V[opParser.X]] = 0;
            
        var startingPc = vm.PC;
        
        new OxEX9E(opcode).Execute(vm);
        
        Assert.Equal(startingPc + 2, vm.PC);
    }
}
