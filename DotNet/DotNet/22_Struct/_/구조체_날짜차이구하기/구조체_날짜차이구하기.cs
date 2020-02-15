using System;

class 구조체_날짜차이구하기
{
    static void Main(string[] args)
    {
        Console.WriteLine("{0}", DateTime.Now.Date);
        Console.WriteLine("{0}", DateTime.Now.TimeOfDay);

        // 시간 차
        TimeSpan xmas = Convert.ToDateTime("2017-12-25") - DateTime.Now;
        Console.WriteLine("올해 크리스마스가 며칠 남았는지: {0}",
            (int)xmas.TotalDays);

        TimeSpan times = DateTime.Now - Convert.ToDateTime("2005-05-27");
        Console.WriteLine("내가 지금까지 며칠 살아왔는지? {0}"
            , times.TotalDays);

        DateTime postDate = DateTime.Now.AddMinutes(101);
        TimeSpan nowDate = DateTime.Now - postDate;
        int totalMinutes = Math.Abs((int)nowDate.TotalMinutes);
        if (totalMinutes < 30)
        {
            Console.WriteLine("{0}분", totalMinutes);
        }
        else if (totalMinutes < 60)
        {
            Console.WriteLine("1시간 내에 쓴 글...");
        }
        else if (totalMinutes < 100)
        {
            Console.WriteLine("100분 이내에 쓴 글");
        }
        else
        {
            Console.WriteLine("100분 전에 쓴 글");
        }
    }
}
