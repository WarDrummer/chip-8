using Chip8.Opcodes;

namespace Chip8.Decoder;

internal class Decoder : IDecoder
{
    IOpcode IDecoder.Decode(ushort opcode)
    {
        return Decode(opcode);
    }
    
    internal static IOpcode Decode(ushort opcode)
    {
        switch (opcode)
        {
            case 0x00E0: return new Ox00E0();
            case 0x00EE: return new Ox00EE();
        }

        switch (opcode & 0xF000)
        {
            case 0x0000: return new Ox0NNN(opcode);
            case 0x1000: return new Ox1NNN(opcode);
            case 0x2000: return new Ox2NNN(opcode);
            case 0x3000: return new Ox3XNN(opcode);
            case 0x4000: return new Ox4XNN(opcode);
            case 0x5000: return new Ox5XY0(opcode);
            case 0x6000: return new Ox6XNN(opcode);
            case 0x7000: return new Ox7XNN(opcode);
            case 0x9000: return new Ox9XY0(opcode);
            case 0xA000: return new OxANNN(opcode);
            case 0xB000: return new OxBNNN(opcode);
            case 0xC000: return new OxCXNN(opcode);
            case 0xD000: return new OxDXYN(opcode);
        }

        switch (opcode & 0xF00F)
        {
            case 0x8000: return new Ox8XY0(opcode);
            case 0x8001: return new Ox8XY1(opcode);
            case 0x8002: return new Ox8XY2(opcode);
            case 0x8003: return new Ox8XY3(opcode);
            case 0x8004: return new Ox8XY4(opcode);
            case 0x8005: return new Ox8XY5(opcode);
            case 0x8006: return new Ox8XY6(opcode);
            case 0x8007: return new Ox8XY7(opcode);
            case 0x800E: return new Ox8XYE(opcode);
        }

        switch (opcode & 0xF0FF)
        {
            case 0xE09E: return new OxEX9E(opcode);
            case 0xE0A1: return new OxEXA1(opcode);
            case 0xF007: return new OxFX07(opcode);
            case 0xF00A: return new OxFX0A(opcode);
            case 0xF015: return new OxFX15(opcode);
            case 0xF018: return new OxFX18(opcode);
            case 0xF01E: return new OxFX1E(opcode);
            case 0xF029: return new OxFX29(opcode);
            case 0xF033: return new OxFX33(opcode);
            case 0xF055: return new OxFX55(opcode);
            case 0xF065: return new OxFX65(opcode);
        }

        return new UnrecognizedOpcode(opcode);
    }
}
