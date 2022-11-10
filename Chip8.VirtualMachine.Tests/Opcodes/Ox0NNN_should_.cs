using Xunit;

// ReSharper disable InconsistentNaming

namespace Chip8.Opcodes;

public class Ox0NNN_should_
{
    [Fact]
    public void throw_not_implemented_exception()
    {
        Assert.Throws<NotImplementedException>(() =>
        {
            new Ox0NNN(0x0000).Execute(new VirtualMachine());
        });
    }
}
