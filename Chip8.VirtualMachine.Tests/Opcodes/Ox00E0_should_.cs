// ReSharper disable InconsistentNaming

using Chip8.IO;
using Moq;

namespace Chip8.Opcodes;

public class Ox00E0_should_
{
    [Fact]
    public void clear_display()
    {
        var mockDisplay = new Mock<IDisplay>();
        var vm = new VirtualMachine(new Decoder(), mockDisplay.Object, new NoKeyboard(), RomReader.Create());
        
        new Ox00E0().Execute(vm);
        
        mockDisplay.Verify(d => d.Clear(), Times.Once);
    }
    
    [Fact]
    public void increment_pc()
    {
        var vm = new VirtualMachine();
        var startingPc = vm.PC;
        
        new Ox00E0().Execute(vm);
        
        Assert.Equal(startingPc + 2, vm.PC);
    }
}
