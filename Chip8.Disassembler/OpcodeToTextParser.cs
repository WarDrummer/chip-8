// ReSharper disable InconsistentNaming

namespace Chip8;

internal class OpcodeToTextParser
{
    protected readonly ushort Opcode;
    public string X => $"V{(Opcode & 0x0F00) >> 8:X1}";

    public string Y => $"V{(Opcode & 0x00F0) >> 4:X1}";

    public string N => $"${Opcode & 0x000F:X1}";

    public string NN => $"${Opcode & 0x00FF:X2}";

    public string NNN => $"${Opcode & 0x0FFF:X3}";

    protected OpcodeToTextParser(ushort opcode)
    {
        Opcode = opcode;
    }
}
