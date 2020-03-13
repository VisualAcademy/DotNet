using System;
using System.Threading.Tasks;

class AsyncAwaitWithTask
{
    //[1] 초간단 async와 await를 사용하는 메서드 만들기
    static async Task RunAsync()
    {
        string message = "Async";
        await Task.Delay(1);
        Console.WriteLine(message);
    }

    static async Task Main()
    {
        //[2] 비동기 메서드 호출
        await RunAsync();
    }
}
