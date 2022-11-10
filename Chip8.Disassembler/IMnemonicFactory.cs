using Chip8.Mnemonics;

namespace Chip8;

internal interface IMnemonicFactory
{
    IMnemonic Parse(ushort opcode);
}