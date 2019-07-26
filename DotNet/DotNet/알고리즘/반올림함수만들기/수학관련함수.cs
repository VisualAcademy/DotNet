using System;

public class 수학관련함수
{
    public static void Main()
    {
        Console.WriteLine( Math.E ); // 자연로그
        Console.WriteLine( Math.PI ); // 3.1415926535

        Console.WriteLine( Math.Abs(-10) ); // 절대값
        Console.WriteLine( Math.Pow(2, 10) ); // 2 ^ 10 = 1024
        Console.WriteLine( Math.Round(1234.5678, 2) ); // 1234.57
        Console.WriteLine( Math.Max(3, 5) ); // 5
        Console.WriteLine( Math.Min(3, 5) ); // 3
    }    
}