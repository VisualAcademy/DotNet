using System;

namespace WorldStandardTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // 현재 시간을 UTC로 가져옵니다.
            DateTime utcNow = DateTime.UtcNow;

            // 세계 표준시 출력
            Console.WriteLine("세계 표준시 : {0}.{1}.{2} {3}:{4}:{5}",
                utcNow.Year,
                utcNow.Month,
                utcNow.Day,
                utcNow.Hour,
                utcNow.Minute,
                utcNow.Second
            );
        }
    }
}