//[?] 배열을 사용하지 않고 3명의 학생의 국어 점수의 총점을 구하려면? 
using System;

class WhyArray
{
    static void Main()
    {
        var kor1 = 90; // 1번 학생
        var kor2 = 80; // 2번 학생
        var kor3 = 70; // 3번 학생

        var tot = kor1 + kor2 + kor3;

        Console.WriteLine($"총점: {tot}"); // 240 
    }
}
