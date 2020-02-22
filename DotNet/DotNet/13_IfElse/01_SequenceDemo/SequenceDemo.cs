using System;

class SequenceDemo
{
    static void Main()
    {
        int kor = 100;
        int eng = 90;

        int tot = 0;
        double avg = 0.0;

        tot = kor + eng; // 총점 구하기
        avg = tot / 2.0; // 평균 구하기 

        Console.WriteLine("총점: {0}", tot);
        Console.WriteLine("평균: {0:F1}", avg);
    }
}
