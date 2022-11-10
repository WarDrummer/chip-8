// ReSharper disable InconsistentNaming

using Xunit;

namespace Chip8.Instructions;

public class NoOp_should_
{
    [Fact]
    public void throw_not_implemented_exception()
    {
        var opcode = OpcodeGenerator.Create("0NNN");
        Assert.Throws<NotImplementedException>(() =>
        {
            new NoOp(opcode).Execute(new VirtualMachine());
        });
    }
}
