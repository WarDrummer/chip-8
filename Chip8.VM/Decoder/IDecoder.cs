using Chip8.VM.Instructions;

namespace Chip8.VM.Decoder;

internal interface IDecoder
{
    IInstruction Decode(ushort opcode);
}
