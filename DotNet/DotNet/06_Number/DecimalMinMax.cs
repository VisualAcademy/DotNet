class DecimalMinMax
{
    static void Main()
    {
        decimal min = System.Decimal.MinValue;
        decimal max = System.Decimal.MaxValue;

        System.Console.WriteLine(min); // -79228162514264337593543950335
        System.Console.WriteLine(max); // +79228162514264337593543950335
    }
}
