// 5명의 학생의 토익 점수를 입력 받아서 전체 학생 평균 이상의 성적인 학생의 수를 구하는 프로그램
// 평균(합계, 카운트) -> 카운트
using System;

class 알고리즘_평균이상학생수
{
    static void Main()
    {
        int[] t = { 100, 90, 80, 70, 60 };

        int sum = 0; // 총점            
        double avg = 0.0; // 평균

        int count = 0; // 학생수(평균 이상)

        // 합계 알고리즘
        for (int i = 0; i < t.Length; i++)
        {
            sum += t[i]; // 누적
        }
        // 평균 알고리즘
        avg = sum / (double)t.Length;

        Console.WriteLine("평균: {0}", avg);

        // 필터링이 적용된 카운트 알고리즘
        for (int i = 0; i < t.Length; i++)
        {
            if (t[i] >= avg) // 평균 이상인 학생수
            {
                count++; // 카운트 알고리즘 적용
            }
        }

        Console.WriteLine("평균 이상 점수 학생 수: {0}", count);
    }
}
