// ReSharper disable InconsistentNaming

using Xunit;

namespace Chip8.Tests;

public class OpcodeGenerator_should_
{
    [Fact]
    public void convert_string_to_opcode()
    {
        var opcode = OpcodeGenerator.Create("F3B9");
        Assert.Equal(0xF3B9, opcode);
    }

    [Fact]
    public void replace_X_with_random_nibble()
    {
        var opcode = OpcodeGenerator.Create("FXB9");
        Assert.Equal(0xF0B9, opcode & 0xF0FF);
    }
    
    [Fact]
    public void replace_Y_with_random_nibble()
    {
        var opcode = OpcodeGenerator.Create("F3Y9");
        Assert.Equal(0xF309, opcode & 0xFF0F);
    }
    
    [Fact]
    public void replace_N_with_random_nibble()
    {
        var opcode = OpcodeGenerator.Create("F3BN");
        Assert.Equal(0xF3B0, opcode & 0xFFF0);
    }
    
    [Fact]
    public void replace_NN_with_random_byte()
    {
        var opcode = OpcodeGenerator.Create("F3NN");
        Assert.Equal(0xF300, opcode & 0xFF00);
    }
    
    [Fact]
    public void replace_NNN_with_random_byte_and_nibble()
    {
        var opcode = OpcodeGenerator.Create("FNNN");
        Assert.Equal(0xF000, opcode & 0xF000);
    }
}