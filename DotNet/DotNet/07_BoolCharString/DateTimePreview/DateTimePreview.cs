using System;

class DateTimePreview
{
    static void Main()
    {
        //[1] 날짜 전체
        Console.WriteLine(DateTime.Now);

        //[2] 각각의 항목을 나눠서 출력
        Console.WriteLine($"{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}");
        Console.WriteLine($"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}");
    }
}
