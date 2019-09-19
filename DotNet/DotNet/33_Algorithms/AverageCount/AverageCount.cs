//[?] 전체 학생 평균 이상의 성적인 학생의 수를 구하는 프로그램
using System;

/// <summary>
/// 평균 이상 학생수 구하기: 평균(합계, 개수) -> 개수 
/// </summary>
class AverageCount
{
    static void Main()
    {
        //[1] Input
        int[] scores = { 100, 90, 80, 70, 60 };
        var sum = 0; // 총점
        var count = 0; // 개수
        var avg = 0.0; // 평균
        var resultCount = 0; // 평균 이상 학생수 

        //[2] Process: SUM, COUNT, AVERAGE -> COUNT
        //[2][1] AVERAGE
        for (int i = 0; i < scores.Length; i++)
        {
            sum += scores[i]; // SUM
            count++; // COUNT
        }
        if (sum != 0 && count != 0)
        {
            avg = sum / (double)count; // AVERAGE            
        }

        //[2][2] 평균 이상 학생수
        for (int i = 0; i < scores.Length; i++)
        {
            if (scores[i] >= avg) // 평균 이상인 학생수
            {
                resultCount++; // 또 다른 COUNT 알고리즘
            }
        }

        //[3] Output
        Console.WriteLine($"평균({avg}점) 이상을 받은 학생수: {resultCount}명");
    }
}
