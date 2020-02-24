// GetSumTwoNumber.cs
using System;

class GetSumTwoNumber
{
    // 두 수의 합을 구하는 함수(메서드)
    static double GetSum(double x, double y)
    {
        double r = x + y;
        return r;
    }

    static void Main()
    {
        double result = GetSum(3.0, 0.14);
        Console.WriteLine(result); // 3.14
    }
}
