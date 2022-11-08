// ReSharper disable InconsistentNaming

using Chip8.Display;
using Chip8.VM;
using Chip8.VM.Decoder;
using Chip8.VM.Instructions;
using Moq;
using Xunit;

namespace Chip8.Tests.Instructions;

public class ClearScreen_00E0_should_
{
    [Fact]
    public void clear_display()
    {
        var mockDisplay = new Mock<IDisplay>();
        var vm = new VirtualMachine(new Decoder(), mockDisplay.Object);
        
        new ClearScreen_00E0().Execute(vm);
        
        mockDisplay.Verify(d => d.Clear(), Times.Once);
    }
    
    [Fact]
    public void increment_pc()
    {
        var vm = new VirtualMachine();
        var startingPc = vm.PC;
        
        new ClearScreen_00E0().Execute(vm);
        
        Assert.Equal(startingPc + 2, vm.PC);
    }
}
