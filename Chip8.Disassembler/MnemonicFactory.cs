using Chip8.Mnemonics;

namespace Chip8;

internal class MnemonicFactory : IMnemonicFactory
{
    IMnemonic IMnemonicFactory.Parse(ushort opcode)
    {
        return Parse(opcode);
    }
    
    // http://devernay.free.fr/hacks/chip8/C8TECH10.HTM#keyboard
    internal static IMnemonic Parse(ushort opcode)
    {
        switch (opcode)
        {
            case 0x00E0: return new CLS(opcode);
            case 0x00EE: return new RET(opcode);
        }

        switch (opcode & 0xF000)
        {
            case 0x0000: return new SYS(opcode);
            case 0x1000: return new JP(opcode);
            case 0x2000: return new CALL(opcode);
            case 0x3000: return new SE(opcode);
            case 0x4000: return new SNE(opcode);
            case 0x5000: return new SER(opcode);
            case 0x6000: return new LD(opcode);
            case 0x7000: return new ADD(opcode);
            case 0x9000: return new SNER(opcode);
            case 0xA000: return new LDI(opcode);
            case 0xB000: return new JPI(opcode);
            case 0xC000: return new RND(opcode);
            case 0xD000: return new DRW(opcode);
        }

        switch (opcode & 0xF00F)
        {
            case 0x8000: return new LDR(opcode);
            case 0x8001: return new OR(opcode);
            case 0x8002: return new AND(opcode);
            case 0x8003: return new XOR(opcode);
            case 0x8004: return new ADDR(opcode);
            case 0x8005: return new SUB(opcode);
            case 0x8006: return new SHR(opcode);
            case 0x8007: return new SUBN(opcode);
            case 0x800E: return new SHL(opcode);
        }

        switch (opcode & 0xF0FF)
        {
            case 0xE09E: return new SKP(opcode);
            case 0xE0A1: return new SKNP(opcode);
            case 0xF007: return new LDXD(opcode);
            case 0xF00A: return new LDXK(opcode);
            case 0xF015: return new LDDX(opcode);
            case 0xF018: return new LDSX(opcode);
            case 0xF01E: return new ADDI(opcode);
            case 0xF029: return new LDFX(opcode);
            case 0xF033: return new LDBX(opcode);
            case 0xF055: return new LDIX(opcode);
            case 0xF065: return new LDXI(opcode);
        }

        return new UnrecognizedOpcode(opcode);
    }
}
