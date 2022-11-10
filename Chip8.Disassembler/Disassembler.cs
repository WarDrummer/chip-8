using System.Text;

namespace Chip8;

public class Disassembler : IDisassembler
{
    private readonly IRomReader _romReader;
    private readonly IMnemonicFactory _mnemonicFactory;

    private Disassembler(IRomReader romReader, IMnemonicFactory mnemonicFactory)
    {
        _romReader = romReader;
        _mnemonicFactory = mnemonicFactory;
    }
    
    internal static IDisassembler Create(IRomReader romReader, IMnemonicFactory mnemonicFactory)
    {
        return new Disassembler(romReader, mnemonicFactory);
    }

    public static IDisassembler Create()
    {
        return new Disassembler(RomReader.Create(), new MnemonicFactory());
    }
    
    public string Disassemble(string romFilePath)
    {
        var opcodes = _romReader.ReadRomAsOpcodes(romFilePath);
        var romText = new StringBuilder();
        foreach (var opcode in opcodes)
        {
            romText.AppendLine(_mnemonicFactory.Parse(opcode).Disassemble());
        }
        return romText.ToString();
    }
}
