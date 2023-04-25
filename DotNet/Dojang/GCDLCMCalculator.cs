using System;

class GCDLCMCalculator
{
    // 두 정수 a와 b의 최대 공약수를 구하는 함수 (재귀 사용)
    static int GCD(int a, int b)
    {
        // b가 0이면 a가 최대 공약수이므로 반환, 그렇지 않으면 재귀적으로 최대 공약수 찾음
        return b == 0 ? a : GCD(b, a % b);
    }

    // 두 정수 a와 b의 최소 공배수를 구하는 함수
    static int LCM(int a, int b)
    {
        // 최소 공배수 공식: a * b / gcd(a, b)
        return a * b / GCD(a, b);
    }

    static void Main()
    {
        int a, b;

        Console.Write("두 개의 정수 입력: ");
        string[] input = Console.ReadLine().Split(' ');
        a = int.Parse(input[0]);
        b = int.Parse(input[1]);

        // 최대 공약수를 계산하고 출력
        Console.WriteLine("최대 공약수: {0}", GCD(a, b));
        // 최소 공배수를 계산하고 출력
        Console.WriteLine("최소 공배수: {0}", LCM(a, b));
    }
}
