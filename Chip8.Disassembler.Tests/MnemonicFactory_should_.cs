// ReSharper disable InconsistentNaming

using Chip8.Mnemonics;

namespace Chip8.Disassembler.Tests;

public class MnemonicFactory_should_
{
    [Theory]
    [InlineData("00E0", typeof(CLR))]
    [InlineData("00EE", typeof(RTS))]
    [InlineData("0NNN", typeof(SystemCall))]
    [InlineData("1NNN", typeof(JUMP))]
    [InlineData("2NNN", typeof(CALL))]
    [InlineData("3XNN", typeof(SKE))]
    [InlineData("4XNN", typeof(SKNE))]
    [InlineData("5XY0", typeof(SKRE))]
    [InlineData("6XNN", typeof(LOAD))]
    [InlineData("7XNN", typeof(ADD))]
    [InlineData("8XY0", typeof(MOVE))]
    [InlineData("8XY1", typeof(OR))]
    [InlineData("8XY2", typeof(AND))]
    [InlineData("8XY3", typeof(XOR))]
    [InlineData("8XY4", typeof(ADDR))]
    [InlineData("8XY5", typeof(SUB))]
    [InlineData("8XY6", typeof(SHR))]
    [InlineData("8XY7", typeof(SUBB))]
    [InlineData("8XYE", typeof(SHL))]
    [InlineData("9XY0", typeof(SKRNE))]
    [InlineData("ANNN", typeof(LOADI))]
    [InlineData("BNNN", typeof(JUMPI))]
    [InlineData("CXNN", typeof(RAND))]
    [InlineData("DXYN", typeof(DRAW))]
    [InlineData("EX9E", typeof(SKPR))]
    [InlineData("EXA1", typeof(SKUP))]
    [InlineData("FX07", typeof(MOVED))]
    [InlineData("FX0A", typeof(KEYD))]
    [InlineData("FX15", typeof(LOADD))]
    [InlineData("FX18", typeof(LOADS))]
    [InlineData("FX1E", typeof(ADDI))]
    [InlineData("FX29", typeof(LDSPR))]
    [InlineData("FX33", typeof(BCD))]
    [InlineData("FX55", typeof(STOR))]
    [InlineData("FX65", typeof(READ))]
    [InlineData("FFFF", typeof(UnrecognizedOpcode))]
    public void create_instance_of_correct_mnemonic_based_on_opcode(string opcodeTemplate, Type instructionType)
    {
        var opcode = OpcodeGenerator.Create(opcodeTemplate);
        var instruction = MnemonicFactory.Parse(opcode);
        Assert.IsType(instructionType, instruction);
    }
}
