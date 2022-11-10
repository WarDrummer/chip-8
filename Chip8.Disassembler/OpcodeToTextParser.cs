// ReSharper disable InconsistentNaming

namespace Chip8;

internal class OpcodeToTextParser
{
    private readonly ushort _opcode;
    protected string X => $"V{(_opcode & 0x0F00) >> 8:X1}";

    protected string Y => $"V{(_opcode & 0x00F0) >> 4:X1}";

    protected string N => $"${_opcode & 0x000F:X1}";

    protected string NN => $"${_opcode & 0x000F:X2}";

    protected string NNN => $"${_opcode & 0x0FFF:X3}";

    protected OpcodeToTextParser(ushort opcode)
    {
        _opcode = opcode;
    }
}
