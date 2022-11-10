// ReSharper disable InconsistentNaming

using Chip8.Decoder;
using Chip8.Instructions;
using Xunit;

namespace Chip8;

public class Decoder_should_
{
    [Theory]
    [InlineData(0x00E0, typeof(ClearScreen_00E0))]
    [InlineData(0x00EE, typeof(ExitSubroutine_00EE))]
    [InlineData(0x0000, typeof(CallMachineCode_0NNN))]
    [InlineData(0x1000, typeof(JumpToAddress_1NNN))]
    [InlineData(0x2000, typeof(EnterSubroutine_2NNN))]
    [InlineData(0x3000, typeof(SkipOnEqualsConstant_3XNN))]
    [InlineData(0x4000, typeof(SkipOnNotEqualsConstant_4XNN))]
    [InlineData(0x5000, typeof(SkipOnEqualsRegister_5XY0))]
    [InlineData(0x6000, typeof(AssignConstant_6XNN))]
    [InlineData(0x7000, typeof(AddConstant_7XNN))]
    [InlineData(0x8000, typeof(AssignRegisterValue_8XY0))]
    [InlineData(0x8001, typeof(BitwiseOr_8XY1))]
    [InlineData(0x8002, typeof(BitwiseAnd_8XY2))]
    [InlineData(0x8003, typeof(BitwiseXor_8XY3))]
    [InlineData(0x8004, typeof(PlusEquals_8XY4))]
    [InlineData(0x8005, typeof(MinusEqual_8XY5))]
    [InlineData(0x8006, typeof(ShiftRight_8XY6))]
    [InlineData(0x8007, typeof(Subtract_8XY7))]
    [InlineData(0x800E, typeof(ShiftLeft_8XYE))]
    [InlineData(0x9000, typeof(SkipOnNotEqualsRegister_9XY0))]
    [InlineData(0xA000, typeof(AssignAddress_ANNN))]
    [InlineData(0xB000, typeof(JumpToAddress_BNNN))]
    [InlineData(0xC000, typeof(RandomNumber_CXNN))]
    [InlineData(0xD000, typeof(Draw_DXYN))]
    [InlineData(0xE09E, typeof(SkipOnKeyPress_EX9E))]
    [InlineData(0xE0A1, typeof(SkipOnNoKeyPress_EXA1))]
    [InlineData(0xF007, typeof(GetDelay_FX07))]
    [InlineData(0xF00A, typeof(GetKeyPress_FX0A))]
    [InlineData(0xF015, typeof(SetDelayTimer_FX15))]
    [InlineData(0xF018, typeof(SetSoundTimer_FX18))]
    [InlineData(0xF01E, typeof(AddToI_FX1E))]
    [InlineData(0xF029, typeof(AssignSprite_FX29))]
    [InlineData(0xF033, typeof(AssignBCD_FX33))]
    [InlineData(0xF055, typeof(DumpRegisters_FX55))]
    [InlineData(0xF065, typeof(LoadRegisters_FX65))]
    [InlineData(0xFFFF, typeof(NoOp))]
    public void create_instance_of_correct_instruction_based_on_opcode(ushort opcode, Type instructionType)
    {
        IDecoder decoder = new Decoder.Decoder();
        var instruction = decoder.Decode(opcode);
        Assert.IsType(instructionType, instruction);
    }
}
