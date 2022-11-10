// ReSharper disable InconsistentNaming

namespace Chip8.Opcodes;

internal class OxCXNN : OpcodeParser, IOpcode
{
    private static readonly Random _random = new ();
    
    internal OxCXNN(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        var random = _random.Next() % 0x100;
        vm.V[X] = (byte)(random & NN);
        vm.PC += 2;
    }
}
