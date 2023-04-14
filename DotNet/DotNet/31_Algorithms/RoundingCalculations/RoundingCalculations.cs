using System;

class RoundingCalculations
{
    static double RoundDecimal(double value, int digits)
    {
        int i;
        double factor = 1.0;
        double roundingValue = 0.5;

        for (i = 0; i < digits; i++)
        {
            roundingValue /= 10.0;
            factor *= 10.0;
        }
        return Math.Floor((value + roundingValue) * factor) / factor;
    }

    static void Main()
    {
        double temp;
        double num = 3.777;
        Console.WriteLine("3자리 반올림: {0:F3}", RoundDecimal(num, 3));
        Console.WriteLine("원래 숫자: {0:F6}", num);
        Console.WriteLine("정수 변환: {0}", (int)num);

        temp = Math.Round(num + 0.5);
        Console.WriteLine("1자리 반올림: {0:F3}", temp);

        temp = Math.Round((num + 0.05) * 10) / 10.0;
        Console.WriteLine("2자리 반올림: {0:F3}", temp);

        temp = Math.Round((num + 0.005) * 100) / 100.0;
        Console.WriteLine("3자리 반올림: {0:F3}", temp);

        temp = Math.Ceiling((num + 0.09) * 10) / 10.0;
        Console.WriteLine("2자리에서 올림: {0:F3}", temp);

        temp = Math.Floor(num * 10) / 10.0;
        Console.WriteLine("2자리에서 내림: {0:F3}", temp);
    }
}
