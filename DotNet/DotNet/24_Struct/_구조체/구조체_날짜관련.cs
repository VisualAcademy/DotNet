using System;

namespace 구조체_날짜관련
{
    class 구조체_날짜관련
    {
        static void Main(string[] args)
        {
            //[1] 현재 시간 출력: DateTime 구조체
            Console.WriteLine($"현재 시간: {DateTime.Now}");

            //[2] 년, 월, 일, 시, 분, 초 출력
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);
            Console.WriteLine(DateTime.Now.Millisecond);

            //[3] DateTime 형식의 변수 선언
            DateTime now = DateTime.Now;
            Console.WriteLine(now.Date);
            Console.WriteLine(now.ToLongTimeString());

            //[4] 시간차(D-Day) 구하기: TimeSpan 구조체
            TimeSpan dday = Convert.ToDateTime("2016-12-25") - DateTime.Now;
            Console.WriteLine(
                $"{DateTime.Now.Year}년도 크리스마스는 {(int)dday.TotalDays}일 남음");
        }
    }
}
