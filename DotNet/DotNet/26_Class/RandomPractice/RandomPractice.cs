using System;

class RandomPractice
{
    static void Main()
    {
        // Random 클래스의 인스턴스 생성
        var rnd = new Random();

        // Next() 메서드를 사용하여 1부터 10까지의 정수 가져오기
        var randomNumber = rnd.Next(1, 11); // 1~10 

        // 랜덤 숫자 출력
        Console.WriteLine($"1~10 사이의 정수: {randomNumber}");
    }
}
