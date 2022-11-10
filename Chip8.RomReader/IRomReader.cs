namespace Chip8;

public interface IRomReader
{
    IEnumerable<byte> ReadRomAsBytes(string filepath);
    IEnumerable<ushort> ReadRomAsOpcodes(string filepath);
}
