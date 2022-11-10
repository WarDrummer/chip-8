// ReSharper disable InconsistentNaming

using Moq;
using Xunit;

namespace Chip8.Instructions;

public class ClearScreen_00E0_should_
{
    [Fact]
    public void clear_display()
    {
        var mockDisplay = new Mock<IDisplay>();
        var vm = new VirtualMachine(new Decoder.Decoder(), mockDisplay.Object, RomReader.Create());
        
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
