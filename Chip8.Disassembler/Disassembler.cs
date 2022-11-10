using System.Text;
using Chip8.Mnemonics;

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
        var lineNumber = 0x200;
        foreach (var opcode in opcodes)
        {
            var mnemonic = _mnemonicFactory.Parse(opcode);
            romText
                .Append($"0x{lineNumber:X4} ")
                .Append($"{opcode:X4}\t")
                .Append(mnemonic.Disassemble())
                .AppendLine();

            lineNumber += 2;
        }
        return romText.ToString();
    }
}
