// 프로세스(Process) : 하나의 프로그램 단위(프로젝트)
// 스레드(Thread) : 프로세스안에서 실행하는 단위 프로그램(메서드)
using System;
using System.Diagnostics;
using System.Threading;

class 스레드
{
    static void Main(string[] args)
    {
        //Win(); Sql(); Ide();
        ThreadStart ts1 = new ThreadStart(Win);
        ThreadStart ts2 = new ThreadStart(Sql);

        Thread t1 = new Thread(ts1);
        Thread t2 = new Thread(ts2);
        Thread t3 = new Thread(new ThreadStart(Ide));

        t3.Priority = ThreadPriority.Highest; // 우선순위 높게 

        t1.Start();
        t2.Start();
        t3.Start();

        // 프로세스
        Process.Start("IExplore.exe"); // 익스플로러 실행
        Process.Start("Notepad.exe");  // 메모장 실행 
    }
    private static void Ide()
    {
        DelayTime();
        Console.WriteLine("[3] IDE : Visual Studio");
    }
    private static void Sql()
    {
        Thread.Sleep(3000); // 3초 딜레이 
        Console.WriteLine("[2] DBMS : SQL Server");
    }
    private static void Win()
    {
        DelayTime();
        Console.WriteLine("[1] OS : Windows Server");
    }
    private static void DelayTime()
    {
        for (int i = 0; i < 100000000; i++) { } // 시간지연 메서드
    }
}
