using Chip8.Mnemonics;

namespace Chip8;

internal interface IMnemonicFactory
{
    IMnemonic Decode(ushort opcode);
}