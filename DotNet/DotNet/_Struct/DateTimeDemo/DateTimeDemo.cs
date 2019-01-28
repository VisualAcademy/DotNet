using System;

class DateTimeDemo
{
    static void Main()
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

        //[3] DateTime 형식의 변수 선언 후 속성 또는 메서드 호출
        DateTime now = DateTime.Now;
        Console.WriteLine(now.Date);
        Console.WriteLine(now.ToLongTimeString());
    }
}
