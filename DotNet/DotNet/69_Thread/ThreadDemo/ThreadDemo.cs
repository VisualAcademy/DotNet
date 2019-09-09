using System;
using System.Threading;

/// <summary>
/// 하나의 스레드는 하나의 작업자
/// </summary>
class ThreadDemo
{
    static void Other()
    {
        Console.WriteLine("[?] 다른 작업자 일 실행");
        Thread.Sleep(1000); // 1초 대기(지연)
        Console.WriteLine("[?] 다른 작업자 일 종료");
    }

    static void Main()
    {
        Console.WriteLine("[1] 메인 작업자 일 시작");

        // Thread 클래스와 ThreadStart 대리자로 새로운 스레드 생성
        var other = new Thread(new ThreadStart(Other));
        other.Start(); // 새로운 스레드 실행

        Console.WriteLine("[2] 메인 작업자 일 종료");
    }
}
