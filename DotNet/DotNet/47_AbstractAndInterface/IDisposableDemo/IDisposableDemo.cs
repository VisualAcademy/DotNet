// IDisposable 인터페이스: 마무리 기능을 자동으로 구현 + using 문과 함께 사용
using System;

class IDisposableDemo
{
    static void Main()
    {
        Console.WriteLine("[1] 열기");
        using (var t = new Toilet())
        {
            // 특정 프로세스 종료시 자동으로 닫기 수행
            Console.WriteLine("[2] 사용");
        }
    }
}

public class Toilet : IDisposable
{
    public void Dispose()
    {
        Console.WriteLine("[3] 닫기");
    }
}
