using Chip8.Mnemonics;

namespace Chip8;

internal class MnemonicFactory : IMnemonicFactory
{
    IMnemonic IMnemonicFactory.Parse(ushort opcode)
    {
        return Parse(opcode);
    }
    
    // https://github.com/craigthomas/Chip8Assembler#chip-8-mnemonics
    internal static IMnemonic Parse(ushort opcode)
    {
        switch (opcode)
        {
            case 0x00E0: return new CLR();
            case 0x00EE: return new RTS();
        }

        switch (opcode & 0xF000)
        {
            case 0x0000: return new SystemCall(opcode);
            case 0x1000: return new JUMP(opcode);
            case 0x2000: return new CALL(opcode);
            case 0x3000: return new SKE(opcode);
            case 0x4000: return new SKNE(opcode);
            case 0x5000: return new SKRE(opcode);
            case 0x6000: return new LOAD(opcode);
            case 0x7000: return new ADD(opcode);
            case 0x9000: return new SKRNE(opcode);
            case 0xA000: return new LOADI(opcode);
            case 0xB000: return new JUMPI(opcode);
            case 0xC000: return new RAND(opcode);
            case 0xD000: return new DRAW(opcode);
        }

        switch (opcode & 0xF00F)
        {
            case 0x8000: return new MOVE(opcode);
            case 0x8001: return new OR(opcode);
            case 0x8002: return new AND(opcode);
            case 0x8003: return new XOR(opcode);
            case 0x8004: return new ADDR(opcode);
            case 0x8005: return new SUB(opcode);
            case 0x8006: return new SHR(opcode);
            case 0x8007: return new SUBB(opcode);
            case 0x800E: return new SHL(opcode);
        }

        switch (opcode & 0xF0FF)
        {
            case 0xE09E: return new SKPR(opcode);
            case 0xE0A1: return new SKUP(opcode);
            case 0xF007: return new MOVED(opcode);
            case 0xF00A: return new KEYD(opcode);
            case 0xF015: return new LOADD(opcode);
            case 0xF018: return new LOADS(opcode);
            case 0xF01E: return new ADDI(opcode);
            case 0xF029: return new LDSPR(opcode);
            case 0xF033: return new BCD(opcode);
            case 0xF055: return new STOR(opcode);
            case 0xF065: return new READ(opcode);
        }

        return new UnrecognizedOpcode(opcode);
    }
}
