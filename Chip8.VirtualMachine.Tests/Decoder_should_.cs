// ReSharper disable InconsistentNaming

using Chip8.Opcodes;

namespace Chip8;

public class Decoder_should_
{
    [Theory]
    [InlineData("00E0", typeof(Ox00E0))]
    [InlineData("00EE", typeof(Ox00EE))]
    [InlineData("0NNN", typeof(Ox0NNN))]
    [InlineData("1NNN", typeof(Ox1NNN))]
    [InlineData("2NNN", typeof(Ox2NNN))]
    [InlineData("3XNN", typeof(Ox3XNN))]
    [InlineData("4XNN", typeof(Ox4XNN))]
    [InlineData("5XY0", typeof(Ox5XY0))]
    [InlineData("6XNN", typeof(Ox6XNN))]
    [InlineData("7XNN", typeof(Ox7XNN))]
    [InlineData("8XY0", typeof(Ox8XY0))]
    [InlineData("8XY1", typeof(Ox8XY1))]
    [InlineData("8XY2", typeof(Ox8XY2))]
    [InlineData("8XY3", typeof(Ox8XY3))]
    [InlineData("8XY4", typeof(Ox8XY4))]
    [InlineData("8XY5", typeof(Ox8XY5))]
    [InlineData("8XY6", typeof(Ox8XY6))]
    [InlineData("8XY7", typeof(Ox8XY7))]
    [InlineData("8XYE", typeof(Ox8XYE))]
    [InlineData("9XY0", typeof(Ox9XY0))]
    [InlineData("ANNN", typeof(OxANNN))]
    [InlineData("BNNN", typeof(OxBNNN))]
    [InlineData("CXNN", typeof(OxCXNN))]
    [InlineData("DXYN", typeof(OxDXYN))]
    [InlineData("EX9E", typeof(OxEX9E))]
    [InlineData("EXA1", typeof(OxEXA1))]
    [InlineData("FX07", typeof(OxFX07))]
    [InlineData("FX0A", typeof(OxFX0A))]
    [InlineData("FX15", typeof(OxFX15))]
    [InlineData("FX18", typeof(OxFX18))]
    [InlineData("FX1E", typeof(OxFX1E))]
    [InlineData("FX29", typeof(OxFX29))]
    [InlineData("FX33", typeof(OxFX33))]
    [InlineData("FX55", typeof(OxFX55))]
    [InlineData("FX65", typeof(OxFX65))]
    [InlineData("FFFF", typeof(UnrecognizedOpcode))]
    public void create_instance_of_correct_opcode_based_on_opcode(string opcodeTemplate, Type opcodeType)
    {
        var opcode = OpcodeGenerator.Create(opcodeTemplate);
        var instruction = Decoder.Decode(opcode);
        Assert.IsType(opcodeType, instruction);
    }
}
