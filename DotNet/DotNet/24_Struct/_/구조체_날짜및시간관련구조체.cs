using System;

namespace 구조체_날짜및시간관련구조체
{
    class 구조체_날짜및시간관련구조체
    {
        static void Main(string[] args)
        {
            // 전체 날짜 및 시간
            Console.WriteLine("{0}", DateTime.Now);

            // 따로 뽑아내기
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;

            // 구조체 형 변수 선언
            DateTime now = DateTime.Now;
            int day = now.Day;
            int hour = now.Hour;
            int minute = now.Minute;
            int second = now.Second;

            Console.WriteLine("{0}-{1}-{2} {3}:{4}:{5}"
                , year, month, day, hour, minute, second);

            // 응용: 생각하는 것 모두 가능 => 구글 / MSDN 온라인 사이트 
            Console.WriteLine("일주일 뒤의 날짜: {0}", DateTime.Now.AddDays(7));
            Console.WriteLine(DateTime.Now.AddYears(-20));


            //[1] DateTime 구조체
            Console.WriteLine("현재날짜/시간 : {0}", DateTime.Now.ToString());
            // 년월일? 시분초? 
            Console.WriteLine("{0}", DateTime.Now.Date.ToShortDateString());

            //[2] TimeSpan 구조체 : 시간차
            TimeSpan ts = DateTime.Now - Convert.ToDateTime("2016-01-01");
            Console.WriteLine("올해가 {0}일 지났습니다.", (int)ts.TotalDays);

            TimeSpan my = DateTime.Parse("2016-12-25") - DateTime.Now;
            Console.WriteLine("올 X마스가 {0}시간 남았습니다.", (int)my.TotalHours);

            DateTime dt = DateTime.Now;
            string result = String.Format("{0}.{1:0#}.{2:0#}", dt.Year, dt.Month, dt.Day);
            Console.WriteLine(result);

            // 며칠 살았는지?
            DateTime myBirthDate = DateTime.Parse("2005-05-27");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthDate);
            Console.WriteLine(myAge.TotalDays); // 소수점 자리까지 표시
        }
    }
}
