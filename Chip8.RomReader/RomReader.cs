namespace Chip8;

public class RomReader : IRomReader
{
    private RomReader() { }

    public static IRomReader Create()
    {
        return new RomReader();
    }
    
    public IEnumerable<byte> ReadRomAsBytes(string filepath)
    {
        using var reader = new BinaryReader(File.Open(filepath, FileMode.Open));

        var rom = reader.ReadBytes(0x1000 - 0x200);
        foreach (var nibble in rom)
        {
            yield return nibble;
        }
    }

    public IEnumerable<ushort> ReadRomAsOpcodes(string filepath)
    {
        using var reader = new BinaryReader(File.Open(filepath, FileMode.Open));

        var rom = reader.ReadBytes(0x1000 - 0x200);
        for (var i = 0; i < rom.Length-1; i += 2)
        {
            var hi = rom[i];
            var lo = rom[i+1];
            yield return (ushort)(hi << 8 | lo);
        }
    }
}
