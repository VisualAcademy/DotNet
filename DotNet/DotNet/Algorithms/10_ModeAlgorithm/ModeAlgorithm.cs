//[?] 주어진 데이터에서 가장 많이 나타난(중복된) 값
using System;

/// <summary>
/// 최빈값 알고리즘(Mode Algorithm): 인덱스(0점~100점)의 개수(COUNT)의 최대값(MAX)
/// </summary>
class ModeAlgorithm
{
    static void Main()
    {
        //[1] Input : 범위: 0부터 100점까지의 점수만 들어온다고 가정
        int[] score = { 1, 3, 4, 3, 5 }; // 0~5까지만 들어온다고 가정
        int mode = 0; // 최빈값이 담길 그릇
        int[] index = new int[5 + 1]; // 0~5까지: 인덱스의 카운터  
        int max = Int32.MinValue;

        //[2] Process
        for (int i = 0; i < score.Length; i++)
        {
            index[score[i]]++; // COUNT
        }
        for (int i = 0; i < index.Length; i++)
        {
            if (index[i] > max)
            {
                max = index[i]; // MAX
                mode = i; // MODE
            }
        }

        //[3] Output
        Console.WriteLine("최빈값: {0} - {1}번", mode, max); // 3, 2
    }
}
