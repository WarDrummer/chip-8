using Chip8.Opcodes;

namespace Chip8.Decoder;

internal interface IDecoder
{
    IOpcode Decode(ushort opcode);
}
