using Xunit;

// ReSharper disable InconsistentNaming

namespace Chip8.Instructions;

public class CallMachineCode_0NNN_should_
{
    [Fact]
    public void throw_not_implemented_exception()
    {
        Assert.Throws<NotImplementedException>(() =>
        {
            new CallMachineCode_0NNN(0x0000).Execute(new VirtualMachine());
        });
    }
}
