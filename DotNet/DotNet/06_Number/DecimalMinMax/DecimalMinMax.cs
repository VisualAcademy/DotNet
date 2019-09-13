using System;

class DecimalMinMax
{
    static void Main()
    {
        decimal min = Decimal.MinValue;
        decimal max = Decimal.MaxValue;

        Console.WriteLine(min); // -79228162514264337593543950335
        Console.WriteLine(max); // +79228162514264337593543950335
    }
}
