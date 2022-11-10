// ReSharper disable InconsistentNaming

using Xunit;

namespace Chip8;

public class OpcodeParser_should_
{
    [Fact]
    public void extract_X_from_opcode()
    {
        var instruction = OpcodeParser.From(0xABCD);
        Assert.Equal(0xB, instruction.X);
    }
    
    [Fact]
    public void extract_Y_from_opcode()
    {
        var instruction = OpcodeParser.From(0xABCD);
        Assert.Equal(0xC, instruction.Y);
    }
    
    [Fact]
    public void extract_N_from_opcode()
    {
        var instruction = OpcodeParser.From(0xABCD);
        Assert.Equal(0xD, instruction.N);
    }
    
    [Fact]
    public void extract_NN_from_opcode()
    {
        var instruction = OpcodeParser.From(0xABCD);
        Assert.Equal(0xCD, instruction.NN);
    }
    
    [Fact]
    public void extract_NNN_from_opcode()
    {
        var instruction = OpcodeParser.From(0xABCD);
        Assert.Equal(0xBCD, instruction.NNN);
    }
}
