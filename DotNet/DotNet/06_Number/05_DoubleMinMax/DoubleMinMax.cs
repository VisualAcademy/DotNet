using System;

class DoubleMinMax
{
    static void Main()
    {
        double min = Double.MinValue; // double 형의 최솟값
        double max = Double.MaxValue; // double 형의 최댓값

        Console.WriteLine(min); // -1.79769313486232E+308
        Console.WriteLine(max); // +1.79769313486232E+308
    }
}
