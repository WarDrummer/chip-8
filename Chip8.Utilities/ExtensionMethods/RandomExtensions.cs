namespace Chip8.ExtensionMethods;

public static class RandomExtensions
{
    public static int NextNibble(this Random random)
    {
        return random.Next() % 0xF;
    }
}