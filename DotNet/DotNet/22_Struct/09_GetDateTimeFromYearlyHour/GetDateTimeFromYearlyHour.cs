using System;

class GetDateTimeFromYearlyHour
{
    static void Main()
    {
        Console.WriteLine(GetDateTimeFromYearlyHourNumber(1));
        Console.WriteLine(GetDateTimeFromYearlyHourNumber(8760/2));
        Console.WriteLine(GetDateTimeFromYearlyHourNumber(8760));
    }

    /// <summary>
    /// 1부터 8760까지의 정수를 입력받아 해당 날짜를 반환해주는 함수 
    /// </summary>
    static DateTime GetDateTimeFromYearlyHourNumber(int number)
    {
        return (new DateTime(2019, 1, 1, 0, 0, 0)).AddHours(--number);        
    }
}
