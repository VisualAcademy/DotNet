//[?] 주어진 데이터에서 가장 많이 나타난(중복된) 값
using System;
using System.Linq;

/// <summary>
/// 최빈값 알고리즘(Mode Algorithm): 점수 인덱스(0~n)의 개수(COUNT)의 최댓값(MAX)
/// </summary>
class ModeAlgorithm
{
    static void Main()
    {
        //[1] Input: 범위는 0부터 n점까지의 점수만 들어온다고 가정
        int[] scores = { 1, 3, 4, 3, 5 }; // 0~5까지만 들어온다고 가정
        int[] indexes = new int[5 + 1]; // 0~5까지 점수 인덱스의 개수 저장  
        int max = int.MinValue; // MAX 알고리즘 적용
        int mode = 0; // 최빈값이 담길 그릇

        //[2] Process: Data -> Index -> Count -> Max -> Mode
        for (int i = 0; i < scores.Length; i++)
        {
            indexes[scores[i]]++; // COUNT
        }
        for (int i = 0; i < indexes.Length; i++)
        {
            if (indexes[i] > max)
            {
                max = indexes[i]; // MAX -> 2
                mode = i; // MODE -> 3
            }
        }

        //[3] Output
        Console.WriteLine($"최빈값(문): {mode} -> {max}번 나타남");
        var q = scores.GroupBy(v => v).OrderByDescending(g => g.Count()).First();
        int modeCount = q.Count(); // 2
        int frequency = q.Key; // 3
        Console.WriteLine($"최빈값(식): {frequency} -> {modeCount}번 나타남");        
    }
}

//scores.ToList().GroupBy(v => v).OrderByDescending(g => g.Count()).First().Key
