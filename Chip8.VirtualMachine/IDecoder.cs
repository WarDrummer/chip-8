using Chip8.Opcodes;

namespace Chip8;

internal interface IDecoder
{
    IOpcode Decode(ushort opcode);
}
