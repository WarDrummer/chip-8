// See https://aka.ms/new-console-template for more information

using Chip8.Display.Console;
using Chip8.VM;

var romPath = args.Length > 0 ? $"Roms/{args[0]}" : "Roms/INVADERS";

var vm = new VirtualMachine(new ConsoleDirectDisplay());
vm.RunProgram(romPath);

Console.CursorVisible = true;
Console.Clear();
Console.WriteLine("Done");
