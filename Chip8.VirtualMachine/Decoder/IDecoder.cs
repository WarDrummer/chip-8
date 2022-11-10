using Chip8.Instructions;

namespace Chip8.Decoder;

internal interface IDecoder
{
    IInstruction Decode(ushort opcode);
}
