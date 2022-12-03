// See https://aka.ms/new-console-template for more information

using Chip8;
using Chip8.IO.ConsoleKeyboard;
using Chip8.IO.Display;

var romPath = args.Length > 0 ? $"Roms/{args[0]}" : "Roms/INVADERS";

// var dasm = Disassembler.Create();
// Console.Write(dasm.Disassemble(romPath));

try
{
    var vm = new VirtualMachine(new ConsoleDirectDisplay(), new ConsoleKeyboard());
    vm.RunProgram(romPath);
}
finally
{
    Console.CursorVisible = true;
    Console.Clear();
    Console.WriteLine("Done");
}
