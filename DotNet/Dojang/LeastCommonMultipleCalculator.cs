using System;

class LeastCommonMultipleCalculator
{
    // 두 정수 a와 b의 최대 공약수를 구하는 메서드(재귀 메서드 사용) 
    static int Gcd(int a, int b)
    {
        // b가 0이면 a가 최대 공약수이므로 반환
        if (b == 0)
        {
            return a;
        }
        // b가 0이 아닌 경우, 재귀적으로 최대 공약수를 찾음
        return Gcd(b, a % b);
    }

    // 두 정수 a와 b의 최소 공배수를 구하는 메서드
    static int Lcm(int a, int b)
    {
        // 최소 공배수 공식: a * b / gcd(a, b)
        return a * b / Gcd(a, b);
    }

    static void Main()
    {
        int a, b;

        Console.Write("두 숫자를 입력하세요: ");
        string input = Console.ReadLine();
        string[] inputs = input.Split();
        a = int.Parse(inputs[0]);
        b = int.Parse(inputs[1]);

        // 최소 공배수를 계산하고 출력하는 부분
        Console.WriteLine("{0}와 {1}의 최소공배수는 {2}입니다.", a, b, Lcm(a, b));
    }
}
