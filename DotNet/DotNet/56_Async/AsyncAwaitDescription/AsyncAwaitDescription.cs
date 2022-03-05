using System;
using System.Threading;
using System.Threading.Tasks;

class AsyncAwaitDescription
{
    static void Main()
    {
        Task.Run(() => DoPrint()); // 1, 2, 3, ...
        Console.WriteLine("[?] async await 사용 예제");
        Thread.Sleep(1); // 1 밀리초 대기 
        //Console.ReadLine();
    } // end Main

    static async void DoPrint()
    {
        await PrintNumberAsync();
    }

    static async Task PrintNumberAsync()
    {
        await Task.Run(() =>
        {
            //[!] 오래 걸리는 작업 들어오는 곳
            for (int i = 0; i < 300; i++)
            {
                Console.WriteLine(i + 1);
            }
        });
    }
}
