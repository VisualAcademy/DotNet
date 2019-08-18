//[?] n명의 점수 중에서 80점 이상 95점 이하인 점수의 평균
using System;

/// <summary>
/// 평균 알고리즘(Average Algorithm): 주어진 범위에 주어진 조건에 해당하는 자료들의 평균
/// </summary>
class AverageAlgorithm
{
    static void Main()
    {
        //[1] 입력: n명의 성적
        int[] data = { 90, 65, 78, 50, 95 };
        int sum = 0; // 합계 담는 그릇
        int count = 0; // 개수 담는 그릇

        //[2] 처리: AVG = SUM / COUNT
        for (int i = 0; i < data.Length; i++) // 주어진 범위
        {
            if (data[i] >= 80 && data[i] <= 95) // 주어진 조건
            {
                sum += data[i]; // SUM
                count++; // COUNT
            }
        }

        double avg = 0.0f;
        if (sum != 0 && count != 0) // 예외 처리
        {
            avg = sum / (double)count; // AVERAGE
        }

        //[3] 출력
        Console.WriteLine($"80점 이상 95점 이하인 자료의 평균: {avg:0.00}"); // 92.5
    }
}

//(new int[] { 50, 65, 78, 90, 95 }).Where(d => d >= 80 && d <= 95).Average()
//92.5
