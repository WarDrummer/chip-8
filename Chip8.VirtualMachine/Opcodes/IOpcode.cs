namespace Chip8.Opcodes;

internal interface IOpcode
{
    void Execute(VirtualMachine vm);
}
