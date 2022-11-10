// ReSharper disable InconsistentNaming

using Xunit;

namespace Chip8.Opcodes;

public class UnrecognizedOpcode_should_
{
    [Fact]
    public void throw_not_implemented_exception()
    {
        var opcode = OpcodeGenerator.Create("0NNN");
        Assert.Throws<NotImplementedException>(() =>
        {
            new UnrecognizedOpcode(opcode).Execute(new VirtualMachine());
        });
    }
}
