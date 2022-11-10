namespace Chip8.Instructions;

internal interface IInstruction
{
    void Execute(VirtualMachine vm);
}
