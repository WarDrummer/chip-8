// See https://aka.ms/new-console-template for more information

using Chip8;
using Chip8.IO.ConsoleKeyboard;
using Chip8.IO.Display;

HashSet<string> GetRomNames(char delimiter)
{
    return new HashSet<string>(
        Directory.GetFiles("Roms")
            .Select(name => name.Split(delimiter).Last())
        );
}

var folderDelimiter = Directory.GetFiles("Roms").First()[4]; 
var romNames = GetRomNames(folderDelimiter);
var selectedRomName = args.Length > 0 ? $"{args[0]}" : "INVADERS";
if (!romNames.Contains(selectedRomName))
{
    Console.WriteLine($"Invalid rom: {selectedRomName}.\n\nChoose one of the following:\n{string.Join(", ", romNames)}");
    Environment.Exit(1);
}

var romPath =  $"Roms{folderDelimiter}{selectedRomName}";

if (args.Length > 1 && args[1] == "--dasm")
{
    var dasm = Disassembler.Create();
    Console.Write(dasm.Disassemble(romPath));
}
else
{
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
}
