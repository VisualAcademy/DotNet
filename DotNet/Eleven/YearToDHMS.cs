using System;

class YearToDHMS
{
    static void Main(string[] args)
    {
        int day, hour, minute, second;
        double year = 365.2425;
        double dHour;
        double dMinute;

        day = (int)year; // 일

        dHour = (year - day) * 24;
        hour = (int)dHour; // 시

        dMinute = (dHour - hour) * 60;
        minute = (int)dMinute; // 분

        second = (int)((dMinute - minute) * 60); // 초

        Console.WriteLine($"1년 = {day}일 {hour}시간 {minute}분 {second}초");
    }
}
