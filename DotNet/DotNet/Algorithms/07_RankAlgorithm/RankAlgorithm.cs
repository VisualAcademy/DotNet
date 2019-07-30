//[?] 주어진(지정한 범위) 데이터의 순위를 구하는 로직
using System;
using System.Linq;

/// <summary>
/// 순위 알고리즘(Rank Algorithm): 점수 데이터에 대한 순위 구하기 
/// </summary>
class RankAlgorithm
{
    static void Main()
    {
        //[1] Input
        int[] scores = { 90, 87, 100, 95, 80 };
        int[] rankings = Enumerable.Repeat(1, 5).ToArray(); // 모두 1로 초기화

        //[2] Process
        for (int i = 0; i < scores.Length; i++)
        {
            rankings[i] = 1; // 1등으로 초기화, 순위 배열을 매 회전마다 1등으로 초기화
            for (int j = 0; j < scores.Length; j++)
            {
                // 현재(i)와 나머지들(j) 비교
                if (scores[i] < scores[j])
                {
                    rankings[i]++; // RANK: 나 보다 큰 점수가 나오면 순위 1증가
                }
            }
        }

        //[3] Output
        for (int i = 0; i < scores.Length; i++)
        {
            Console.WriteLine("{0,3}점: {1}등", scores[i], rankings[i]);
        }
    }
}

//int[] scores = { 90, 87, 100, 95, 80 };

//var rankings = scores.Select(s => scores.Where(ss => ss > s).Count() + 1).ToArray();
//rankings
//int[5] { 3, 4, 1, 2, 5 }

//var rankings = scores.Select(s => new { Score = s, Rank = scores.Where(ss => ss > s).Count() + 1 });
//rankings
