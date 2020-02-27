//[?] n명의 점수 중에서 80점 이상인 점수의 합계
using System;

/// <summary>
/// 합계 알고리즘(Sum Algorithm): 주어진 범위에 주어진 조건에 해당하는 자료들의 합계
/// </summary>
class SumAlgorithm
{
    static void Main()
    {
        //[1] Input: n명의 점수
        int[] scores = { 100, 75, 50, 37, 90, 95 };
        int sum = 0; // 합계가 담길 그릇

        //[2] Process: 합계 알고리즘 영역: 주어진 범위에 주어진 조건(필터링)
        for (int i = 0; i < scores.Length; i++) // 주어진 범위
        {
            if (scores[i] >= 80) // 주어진 조건
            {
                sum += scores[i]; // SUM
            }
        }

        //[3] Output
        Console.WriteLine($"{scores.Length}명의 점수 중 80점 이상의 총점: {sum}");

        //[!] 디버거(디버깅 S/W)를 사용하여 디버깅하기: F9 -> F5 -> F11 -> F5 
    }
}

//(new int[] { 100, 75, 50, 37, 90, 95 }).Where(s => s >= 80).Sum() // Statement -> Expression
//285
