// ReSharper disable InconsistentNaming
namespace Chip8.VM.OpcodeParser;

internal interface IOpcodeParser
{
    byte X { get; }
    byte Y { get; }
    byte N { get; }
    byte NN { get; }
    ushort NNN { get; }
}
