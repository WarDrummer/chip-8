// ReSharper disable InconsistentNaming

namespace Chip8.Instructions;

internal class Draw_DXYN : OpcodeParser, IInstruction
{
    private readonly ushort[] _bitMasks = { 128, 64, 32, 16, 8, 4, 2, 1 };
    
    internal Draw_DXYN(ushort opcode) : base(opcode)
    {
    }
        
    public void Execute(VirtualMachine vm)
    {
        try
        {
            var vx = vm.V[X];
            var vy = vm.V[Y];
            var I = vm.I;
            
            vm.VF = 0;
            for (var y = 0; y < N; y++)
            {
                var index = vx + (vy + y) * 64;

                ushort pixel = vm.Memory[I + y];
                                
                for (var x = 0; x < 8; x++)
                {
                    if ((pixel & _bitMasks[x]) != 0)
                    {
                        var idx = index + x;
                            
                        if (vm.Display.Pixels[idx] == 1)
                        {
                            vm.VF = 1;
                            vm.Display.Pixels[idx] = 0;
                        }
                        else
                        {
                            vm.Display.Pixels[idx] = 1;
                        }
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            Console.WriteLine(vm);
            throw;
        }
        
        vm.PC += 2;
    }
}
