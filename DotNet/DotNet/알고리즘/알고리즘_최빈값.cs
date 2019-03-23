// 최빈값(MODE) : 가장 많이 나타난 값
// -> 데이터의 인덱스(0점~100점)의 카운트(COUNT)값의 최댓값(MAX)
using System;

class 알고리즘_최빈값
{
    static void Main()
    {
        //[1] Input : 범위 : 0부터 100점까지의 점수만 들어온다고 가정
        int[] score = { 1, 3, 4, 3, 5 }; // 0~5까지만 들어온다고 가정
        int mode = 0; // 최빈값이 담길 그릇
        int[] index = new int[5 + 1]; // 0~5까지 : 인덱스의 카운터  
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
        Console.WriteLine("최빈값 : {0}, {1}번", mode, max); // 3, 2
    }
}
