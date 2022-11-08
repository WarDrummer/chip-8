using Chip8.VM.Instructions;

namespace Chip8.VM.Decoder;

internal class Decoder : IDecoder
{
    IInstruction IDecoder.Decode(ushort opcode)
    {
        return Decode(opcode);
    }
    
    internal static IInstruction Decode(ushort opcode)
    {
        switch (opcode)
        {
            case 0x00E0: return new ClearScreen_00E0();
            case 0x00EE: return new ExitSubroutine_00EE();
        }

        switch (opcode & 0xF000)
        {
            case 0x0000: return new CallMachineCode_0NNN(opcode);
            case 0x1000: return new JumpToAddress_1NNN(opcode);
            case 0x2000: return new EnterSubroutine_2NNN(opcode);
            case 0x3000: return new SkipOnEqualsConstant_3XNN(opcode);
            case 0x4000: return new SkipOnNotEqualsConstant_4XNN(opcode);
            case 0x5000: return new SkipOnEqualsRegister_5XY0(opcode);
            case 0x6000: return new AssignConstant_6XNN(opcode);
            case 0x7000: return new AddConstant_7XNN(opcode);
            case 0x9000: return new SkipOnNotEqualsRegister_9XY0(opcode);
            case 0xA000: return new AssignAddress_ANNN(opcode);
            case 0xB000: return new JumpToAddress_BNNN(opcode);
            case 0xC000: return new RandomNumber_CXNN(opcode);
            case 0xD000: return new Draw_DXYN(opcode);
        }

        switch (opcode & 0xF00F)
        {
            case 0x8000: return new AssignRegisterValue_8XY0(opcode);
            case 0x8001: return new BitwiseOr_8XY1(opcode);
            case 0x8002: return new BitwiseAnd_8XY2(opcode);
            case 0x8003: return new BitwiseXor_8XY3(opcode);
            case 0x8004: return new PlusEquals_8XY4(opcode);
            case 0x8005: return new MinusEqual_8XY5(opcode);
            case 0x8006: return new ShiftRight_8XY6(opcode);
            case 0x8007: return new Subtract_8XY7(opcode);
            case 0x800E: return new ShiftLeft_8XYE(opcode);
        }

        switch (opcode & 0xF0FF)
        {
            case 0xE09E: return new SkipOnKeyPress_EX9E(opcode);
            case 0xE0A1: return new SkipOnNoKeyPress_EXA1(opcode);
            case 0xF007: return new GetDelay_FX07(opcode);
            case 0xF00A: return new GetKeyPress_FX0A(opcode);
            case 0xF015: return new SetDelayTimer_FX15(opcode);
            case 0xF018: return new SetSoundTimer_FX18(opcode);
            case 0xF01E: return new AddToI_FX1E(opcode);
            case 0xF029: return new AssignSprite_FX29(opcode);
            case 0xF033: return new AssignBCD_FX33(opcode);
            case 0xF055: return new DumpRegisters_FX55(opcode);
            case 0xF065: return new LoadRegisters_FX65(opcode);
        }

        return new NoOp(opcode);
    }
}
