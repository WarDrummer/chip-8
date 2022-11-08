using Chip8.VM;

namespace Chip8.Tests.ExtensionMethods;

public static class VirtualMachineExtensions
{
    private static readonly Random Random = new();
    
    internal static VirtualMachine RandomizeRegisters(this VirtualMachine vm, byte maxValue = byte.MaxValue)
    {
        for (var i = 0x0; i < 0xF; i++)
        {
            vm.V[i] = (byte)(Random.Next() % maxValue);
        }

        return vm;
    }
    
    internal static VirtualMachine RandomizeI(this VirtualMachine vm)
    {
        vm.I = (ushort)(Random.Next() % ushort.MaxValue);
        return vm;
    }
        
    internal static VirtualMachine RandomizeDelayTimer(this VirtualMachine vm)
    {
        vm.DelayTimer = (byte)(Random.Next() % byte.MaxValue);
        return vm;
    }
        
    internal static VirtualMachine RandomizeSoundTimer(this VirtualMachine vm)
    {
        vm.SoundTimer = (byte)(Random.Next() % byte.MaxValue);
        return vm;
    }

    internal static VirtualMachine SetRandomKey(this VirtualMachine vm)
    {
        vm.Keys[Random.Next() % vm.Keys.Length] = 1;
        return vm;
    }
    
    internal static VirtualMachine RandomizeKeys(this VirtualMachine vm)
    {
        for (var i = 0; i < 0xF; i++)
        {
            vm.Keys[i] = (byte)(Random.Next() % 2);
        }

        return vm;
    }
}
