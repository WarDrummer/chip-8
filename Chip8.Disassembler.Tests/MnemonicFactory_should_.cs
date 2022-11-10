// ReSharper disable InconsistentNaming

using Chip8.Mnemonics;

namespace Chip8.Disassembler.Tests;

public class MnemonicFactory_should_
{
    [Theory]
    [InlineData("00E0", typeof(CLS))]
    [InlineData("00EE", typeof(RET))]
    [InlineData("0NNN", typeof(SYS))]
    [InlineData("1NNN", typeof(JP))]
    [InlineData("2NNN", typeof(CALL))]
    [InlineData("3XNN", typeof(SE))]
    [InlineData("4XNN", typeof(SNE))]
    [InlineData("5XY0", typeof(SER))]
    [InlineData("6XNN", typeof(LD))]
    [InlineData("7XNN", typeof(ADD))]
    [InlineData("8XY0", typeof(LDR))]
    [InlineData("8XY1", typeof(OR))]
    [InlineData("8XY2", typeof(AND))]
    [InlineData("8XY3", typeof(XOR))]
    [InlineData("8XY4", typeof(ADDR))]
    [InlineData("8XY5", typeof(SUB))]
    [InlineData("8XY6", typeof(SHR))]
    [InlineData("8XY7", typeof(SUBN))]
    [InlineData("8XYE", typeof(SHL))]
    [InlineData("9XY0", typeof(SNER))]
    [InlineData("ANNN", typeof(LDI))]
    [InlineData("BNNN", typeof(JPI))]
    [InlineData("CXNN", typeof(RND))]
    [InlineData("DXYN", typeof(DRW))]
    [InlineData("EX9E", typeof(SKP))]
    [InlineData("EXA1", typeof(SKNP))]
    [InlineData("FX07", typeof(LDXD))]
    [InlineData("FX0A", typeof(LDXK))]
    [InlineData("FX15", typeof(LDDX))]
    [InlineData("FX18", typeof(LDSX))]
    [InlineData("FX1E", typeof(ADDI))]
    [InlineData("FX29", typeof(LDFX))]
    [InlineData("FX33", typeof(LDBX))]
    [InlineData("FX55", typeof(LDIX))]
    [InlineData("FX65", typeof(LDXI))]
    [InlineData("FFFF", typeof(UnrecognizedOpcode))]
    public void create_instance_of_correct_mnemonic_based_on_opcode(string opcodeTemplate, Type instructionType)
    {
        var opcode = OpcodeGenerator.Create(opcodeTemplate);
        var instruction = MnemonicFactory.Parse(opcode);
        Assert.IsType(instructionType, instruction);
    }
}
