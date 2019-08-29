//[?] 무작위 데이터를 순서대로 [오름차순(ASC)|내림차순(DESC)] 정렬
using System;

/// <summary>
/// 정렬 알고리즘(Sort Algorithm): 가장 [작은|큰] 데이터를 왼쪽으로 순서대로 이동
/// </summary>
class SortAlgorithm
{
    static void Main()
    {
        //[1] Input: Data Structure(Array, List, Stack, Queue, Tree, DB, ...)
        int[] data = { 3, 2, 1, 5, 4 }; // 정렬되지 않은 데이터
        int N = data.Length; // 의사코드(슈도코드) 형태로 알고리즘을 표현하기 위함

        //[2] Process: Selection Sort(선택 정렬) 알고리즘
        for (int i = 0; i < N - 1; i++) // i = 0 to N - 1
        { 
            for (int j = i + 1; j < N; j++) // j = i + 1 to N
            {
                if (data[i] > data[j]) // 부등호 방향: 오름차순(>), 내림차순(<)
                {
                    int temp = data[i]; data[i] = data[j]; data[j] = temp; // SWAP
                }
            }
        }

        //[3] Output: UI(Console, Desktop, Web, Mobile, ...)
        for (int i = 0; i < N; i++)
        {
            Console.Write($"{data[i]}\t");
        }
        Console.WriteLine();
    }
}

//int[] data = { 3, 2, 1, 5, 4 };
//Array.Sort(data);
//data
//int[5] { 1, 2, 3, 4, 5 }
//int[] data = { 3, 2, 1, 5, 4 };
//var sort = data.OrderBy(n => n).ToArray();
//sort
//int[5] { 1, 2, 3, 4, 5 }
