
using Chip8.ExtensionMethods;

namespace Chip8;

public static class OpcodeGenerator
{
    private static readonly Random Random = new();
    private static readonly string HexValues = "0123456789ABCDEF";
    private static readonly string RegisterSymbols = "XY";
    private static readonly string ConstantSymbols = "N";
    private static readonly string ValidTemplateCharacters = $"{HexValues}{RegisterSymbols}{ConstantSymbols}";
    
    private static readonly HashSet<char> ValidTemplateCharactersLookup = new(ValidTemplateCharacters.ToCharArray());
    private static readonly Dictionary<char, ushort> HexLetterToValue = new()
    {
        {'0', 0 }, {'1', 1 }, {'2', 2 }, {'3', 3 }, {'4', 4 }, {'5', 5 }, {'6', 6 }, {'7', 7 },
        {'8', 8 }, {'9', 9 }, {'A', 10 }, {'B', 11 }, {'C', 12 }, {'D', 13 }, {'E', 14 }, {'F', 15 },
    };
    
    public static ushort Create(string opcodeTemplate)
    {
        if (opcodeTemplate.Length != 4)
        {
            throw new Exception("Opcodes must be 4 characters in length.");
        }

        foreach (var c in opcodeTemplate.Where(c => !ValidTemplateCharactersLookup.Contains(c)))
        {
            throw new Exception($"{c} is not a valid character. Valid characters are {ValidTemplateCharacters}");
        }

        ushort opcode = 0;
        var usedRegisterValues = new HashSet<int>(2);
        for (var i = 0; i < 4; i++)
        {
            var nibble = opcodeTemplate[i];
            var offset = (4 - i - 1) * 4;

            if (ConstantSymbols.Contains(nibble))
            {
                opcode += (ushort)(Random.NextNibble() << offset);
            }
            else if (RegisterSymbols.Contains(nibble))
            {
                // Do not repeat register values
                var register = Random.NextNibble();
                while (usedRegisterValues.Contains(register))
                {
                    register = Random.NextNibble();
                }
                usedRegisterValues.Add(register);
                
                opcode += (ushort)(register << offset);
            }
            else
            {
                opcode += (ushort)(HexLetterToValue[nibble] << offset);
            }
        }

        return opcode;
    }
}
