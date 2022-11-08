// ReSharper disable InconsistentNaming

using Chip8.Tests.ExtensionMethods;
using Chip8.VM;
using Chip8.VM.Instructions;
using Chip8.VM.OpcodeParser;
using Xunit;

namespace Chip8.Tests.Instructions;

public class AssignRegisterValue_8XY0_should_
{
    [Fact]
    public void assign_value_of_vx_to_vy()
    {
        var opcode = OpcodeGenerator.Create("8XY0");
        var opParams = OpcodeParser.From(opcode);
        
        var vm = new VirtualMachine()
            .RandomizeRegisters();
        
        new AssignRegisterValue_8XY0(opcode).Execute(vm);
        
        Assert.Equal(vm.V[opParams.X], vm.V[opParams.Y]);
    }
    
    [Fact]
    public void increment_pc()
    {
        var opcode = OpcodeGenerator.Create("8XY0");
        
        var vm = new VirtualMachine();
        var startingPc = vm.PC;
        
        new AssignRegisterValue_8XY0(opcode).Execute(vm);
        
        Assert.Equal(startingPc + 2, vm.PC);
    }
}
