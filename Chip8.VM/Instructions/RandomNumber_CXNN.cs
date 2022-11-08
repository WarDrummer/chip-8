// ReSharper disable InconsistentNaming

namespace Chip8.VM.Instructions;

internal class RandomNumber_CXNN : OpcodeParser.OpcodeParser, IInstruction
{
    private static readonly Random _random = new ();
    
    internal RandomNumber_CXNN(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        var random = _random.Next() % 0x100;
        vm.V[X] = (byte)(random & NN);
        vm.PC += 2;
    }
}
