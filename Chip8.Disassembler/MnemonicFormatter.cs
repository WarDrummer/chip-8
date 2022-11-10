namespace Chip8;

internal class MnemonicFormatter : OpcodeToTextParser
{
    private const int MaxOpLength = 5;
    
    public string Format(string op, params string[] args)
    {
        return $"{op,MaxOpLength} \t{string.Join(", ", args)}";
    }

    protected MnemonicFormatter(ushort opcode) : base(opcode)
    {
    }
}
