using System;

class 날짜와시간관련구조체
{
    static void Main(string[] args)
    {
        //[1] 날짜/시간 전체 출력
        Console.WriteLine("현재: {0}", DateTime.Now);
        Console.WriteLine("시간: {0}", DateTime.Now.Hour); // 원하는 값?

        //[2] DateTime 형식 변수를 통한 출력
        DateTime dtNow = DateTime.Now;
        string strToday =
            String.Format("현재 : {0}년 {1}월 {2}일 {3}시 {4}분 {5}초",
                dtNow.Year, dtNow.Month, dtNow.Day, 
                dtNow.Hour, dtNow.Minute, dtNow.Second);
        Console.WriteLine(strToday);

        //[3] 요일 출력
        Console.WriteLine("요일 : {0}", DateTime.Now.DayOfWeek.ToString());

        //[4] 기타: 내가 원하는 정보는 MSDN 검색 / 검색 엔진을 통해서 구할 수 있다.

    }
}
