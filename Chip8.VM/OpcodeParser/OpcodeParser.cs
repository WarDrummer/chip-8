// ReSharper disable InconsistentNaming

namespace Chip8.VM.OpcodeParser;

internal class OpcodeParser : IOpcodeParser
{
    internal ushort Opcode { get; }
    public byte X => (byte)((Opcode & 0x0F00) >> 8);
    public byte Y => (byte)((Opcode & 0x00F0) >> 4);
    public byte N => (byte)(Opcode & 0x000F);
    public byte NN => (byte)(Opcode & 0x00FF);
    public ushort NNN => (ushort)(Opcode & 0x0FFF);
    
    protected OpcodeParser(ushort opcode)
    {
        Opcode = opcode;
    }

    internal static OpcodeParser From(ushort opcode)
    {
        return new OpcodeParser(opcode);
    }
}
