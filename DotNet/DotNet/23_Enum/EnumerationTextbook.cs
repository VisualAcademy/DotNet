using System;

class EnumerationTextbook
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Red");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.BackgroundColor = ConsoleColor.White;
        Console.WriteLine($"{nameof(ConsoleColor.Yellow)} & {nameof(ConsoleColor.White)}");
        Console.ResetColor();
    }
}
