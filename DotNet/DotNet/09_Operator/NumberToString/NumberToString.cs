using System;

class NumberToString
{
    static void Main()
    {
        int days = 28;

        //[1] 암시적(Implicit)으로 숫자 형식을 문자열로 변환하기 
        Console.WriteLine("2월달은 " + days + "일입니다.");

        //[2] 명시적(Explicit)으로 숫자 형식을 문자열로 변환하기: 2가지 방법 
        Console.WriteLine("2월달은 " + days.ToString() + "일입니다.");
        Console.WriteLine("2월달은 " + Convert.ToString(days) + "일입니다.");
    }
}
