using System;

class PrecisionDemo
{
    static void Main()
    {
        int dividend = 3, divisor = 4;
        double quotient;
        quotient = (double)dividend / divisor;  // 개선된 부분
        Console.WriteLine("Division result: {0}", quotient);
    }
}
