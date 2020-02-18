using System;

class RandomDemo
{
    static void Main()
    {
        // Random 클래스의 인스턴스 생성
        Random random = new Random();

        Console.WriteLine(random.Next());       // 임의의 정수
        Console.WriteLine(random.Next(5));      // 0 ~ 4
        Console.WriteLine(random.Next(1, 10));  // 1 ~ 10
    }
}
