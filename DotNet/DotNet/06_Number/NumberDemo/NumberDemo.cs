using System;

class NumberDemo
{
    static void Main()
    {
        // float: 32비트
        Console.WriteLine("float 최솟값: {0}", float.MinValue);
        Console.WriteLine("float 최댓값: {0}", float.MaxValue);

        // double: 64비트
        Console.WriteLine("double 최솟값: {0}", double.MinValue);
        Console.WriteLine("double 최댓값: {0}", double.MaxValue);

        // decimal: 128비트
        decimal min = Decimal.MinValue;
        decimal max = Decimal.MaxValue;
        Console.WriteLine("decimal 최솟값: {0}", min);
        Console.WriteLine("decimal 최댓값: {0}", max);
    }
}
