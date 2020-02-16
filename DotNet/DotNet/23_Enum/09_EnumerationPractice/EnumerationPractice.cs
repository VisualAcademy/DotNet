using System;

enum Color
{
    Red = 10,
    Green,
    Blue = 20
}

class EnumerationPractice
{
    static void Main()
    {
        int red = (int)Color.Red;
        int green = (int)Color.Green;
        int blue = (int)Color.Blue;

        Console.WriteLine($"Red: {red}, Green: {green}, Blue: {blue}"); // 0, 1, 2
    }
}
