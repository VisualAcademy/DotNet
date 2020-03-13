using System;
using System.Threading.Tasks;

// 병렬 처리(Parallel Processing): 스레드를 직접 만들지 않고 다중 스레드로 처리
class ParallelFor
{
    static void Main()
    {
        Parallel.For(0, 200_000, (i) => { Console.WriteLine(i); });
    }
}
