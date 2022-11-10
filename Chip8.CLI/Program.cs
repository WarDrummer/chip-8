// See https://aka.ms/new-console-template for more information

using Chip8;
using Chip8.Display;

var romPath = args.Length > 0 ? $"Roms/{args[0]}" : "Roms/INVADERS";

var vm = new VirtualMachine(new ConsoleDirectDisplay());
vm.RunProgram(romPath);

// var dasm = Disassembler.Create();
// Console.Write(dasm.Disassemble(romPath));

Console.CursorVisible = true;
Console.Clear();
Console.WriteLine("Done");
