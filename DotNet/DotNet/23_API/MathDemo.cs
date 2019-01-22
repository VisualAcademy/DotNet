using System;
using static System.Console; 

class MathDemo
{
    static void Main()
    {
        //[1] 수학 관련 상수
        WriteLine($"자연 로그: {Math.E}");
        WriteLine($"원주율(PI): {Math.PI}");

        //[2] 절댓값
        WriteLine($"-10의 절댓값: {Math.Abs(-10)}");
        WriteLine(Math.Abs(-10));// // 절댓값 |-10| -> 10

        //[3] 최댓값, 최솟값
        WriteLine(Math.Max(3, 5)); // 5
        WriteLine(Math.Min(3, 5)); // 3

        //[4] 거듭제곱
        Console.WriteLine($"거듭제곱: 2의 10승: {Math.Pow(2, 10)}");
        Console.WriteLine(Math.Pow(2, 10));// 2의 10승 1024Byte -> 1KB

        //[5] 반올림
        Console.WriteLine(
            $"3.15를 소수점 둘째자리에서 반올림: {Math.Round(3.15, 1)}"); // 3.2
        // 반올림: 3.777을 소수점 둘째자리까지 반올림 : 3.78
        Console.WriteLine(Math.Round(3.777, 2)); 

        //[!] 사용자 정의 함수로 표현해보기
        //[1] 절댓값
        Console.WriteLine(Math.Abs(-10)); // |-10| -> 10
        Console.WriteLine(MyAbs(-10)); // 10

        //[2] 최대/최소 : Math.Max(), Math.Min()
        Console.WriteLine(Math.Max(10, 5)); // 10
        Console.WriteLine(MyMax(10, 5)); // 10

        //[3] 제곱근 : Math.Pow(x, y)
        Console.WriteLine(Math.Pow(2, 20)); // 1048576
        Console.WriteLine(MyPow(2, 10)); // 1024

        //[4] 반올림 : Math.Round()
        Console.WriteLine(Math.Round(3.1415, 3)); // 3.142
        Console.WriteLine("{0}", MyRound(3.141592, 2)); // 3.1
    }

    // p의 p_2승 구하는 메서드
    private static int MyPow(int p, int p_2)
    {
        int sum = 1;
        for (int i = 0; i < p_2; i++)
        {
            sum *= p;
        }
        return sum;
    }

    // 넘겨온 두 수 중 최댓값을 반환
    private static int MyMax(int p, int p_2)
    {
        return (p > p_2) ? p : p_2; // 큰 값을 반환
    }

    public static int MyMin(int a, int b)
    {
        return (a > b) ? b : a; // 작은 수 반환
    }

    // 넘겨온 데이터에 대한 절댓값을 구해주는 메서드
    private static int MyAbs(int p)
    {
        return (p < 0) ? -p : p; // 절대값
    }

    /// <summary>
    /// b가 0이면 소수점 첫째자리 반올림, 1면 둘째자리 반올림
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static double MyRound(double a, int b)
    {
        if (b == 0) // 3.14 -> 3.0
        {
            return (int)(a * 0.5);
        }
        else if (b == 1) // 3.14 -> 3.1 
        {
            return (int)((a + 0.05) * 10) / 10.0;
        }
        else // if (b == 2) // 3.141 -> 3.14
        {
            return (int)((a + 0.005) * 100) / 100.0;
        }
    }
}
