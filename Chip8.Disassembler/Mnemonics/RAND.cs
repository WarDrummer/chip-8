// ReSharper disable InconsistentNaming

namespace Chip8.Mnemonics;

internal class RAND : OpcodeToTextParser, IMnemonic
{
    private static readonly Random _random = new ();
    
    internal RAND(ushort opcode) : base(opcode)
    {
    }

    public string Disassemble()
    {
        return $"RAND {X}, {NN}";
    }
}
