// 프로그램명: StopwatchDemo
// Stopwatch 클래스를 사용하여 간단히 특정 프로세스(메서드, 로직)의 경과 시간을
// 밀리초 단위로 표시하는 기능을 구현하는 예제입니다.
using System;
using System.Diagnostics;
using System.Threading;

class StopwatchDemo
{
    static void Main()
    {
        // Stopwatch 클래스 : 특정 프로세스의 경과 시간(Elapsed)을 구하는 기능
        Stopwatch timer = new Stopwatch();
        timer.Start();
        LongTimeProcess();
        timer.Stop();

        // 밀리초 단위로 표시
        Console.WriteLine("경과 시간: {0}밀리초", timer.Elapsed.TotalMilliseconds); 
        // 초 단위로 표시 
        Console.WriteLine("경과 시간: {0}초", timer.Elapsed.Seconds);
    }

    static void LongTimeProcess()
    {
        // 3초간 대기: Thread.Sleep() 메서드로 현재 프로그램 3초가 대기
        Thread.Sleep(3000);
    }
}
