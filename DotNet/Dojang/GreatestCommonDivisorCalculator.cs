using System;

class GreatestCommonDivisorCalculator
{
    // 두 정수 a와 b의 최대 공약수를 구하는 메서드
    static int Gcd(int a, int b)
    {
        int c;
        // b가 0이 아닐 때까지 반복
        while (b != 0)
        {
            // a를 b로 나눈 나머지를 c에 저장
            c = a % b;
            // a에는 b 값을 대입하여 b가 더 작은 값이 되도록 함
            a = b;
            // b에는 c 값을 대입하여 b를 a를 나눈 나머지로 변경함
            b = c;
        }
        // 최대 공약수를 반환
        return a;
    }

    static void Main()
    {
        int a, b;

        Console.Write("두 정수를 입력하세요: ");
        // 사용자로부터 두 정수를 입력받음
        string[] input = Console.ReadLine().Split();
        a = int.Parse(input[0]);
        b = int.Parse(input[1]);

        // 최대 공약수를 계산하고 출력
        Console.WriteLine("{0}와 {1}의 최대 공약수는: {2}입니다.", a, b, Gcd(a, b));
    }
}
