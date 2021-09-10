//[?] 무작위 데이터를 순서대로 [오름차순(ASC)|내림차순(DESC)] 정렬
using System;

/// <summary>
/// 정렬 알고리즘(Sort Algorithm): 가장 [큰] 데이터를 오른쪽으로 순서대로 이동
/// </summary>
class BubbleSort
{
    static void Main()
    {
        //[1] Input
        int[] data = { 3, 2, 1, 5, 4 };
        int N = data.Length;

        //[2] Process: Bubble Sort(거품 정렬) 알고리즘
        for (int i = 0; i < N - 1; i++)
        {
            for (int j = 1; j < (N - i); j++)
            {
                if (data[j - 1] < data[j]) // 부등호 방향: 오름차순(>), 내림차순(<)
                {
                    int temp = data[j - 1];
                    data[j - 1] = data[j];
                    data[j] = temp;
                }
            }
        }

        //[3] Output
        for (int i = 0; i < N; i++)
        {
            Console.Write($"{data[i]}\t");
        }
        Console.WriteLine();
    }
}
