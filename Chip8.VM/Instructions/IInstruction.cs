namespace Chip8.VM.Instructions;

internal interface IInstruction
{
    void Execute(VirtualMachine vm);
}
