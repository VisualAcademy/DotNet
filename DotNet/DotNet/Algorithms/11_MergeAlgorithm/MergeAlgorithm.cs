//[?] 2개의 정수 배열 합치기, 단 2개의 배열은 오름차순으로 정렬되어 있다고 가정
using System;

/// <summary>
/// 병합 알고리즘(Merge Algorithm): 오름차순으로 정렬되어 있는 정수 배열을 하나로 병합
/// </summary>
class MergeAlgorithm
{
    static void Main()
    {
        //[1] Input
        int[] first = { 1, 3, 5 };
        int[] second = { 2, 4 };
        int[] merge = new int[first.Length + second.Length]; // MEARGE될 배열
        int i = 0; int j = 0; int k = 0;
        int M = first.Length; int N = second.Length;

        //[2] Process
        while (i < M && j < N)              // 모두 끝에 도달할 때까지
        {
            if (first[i] <= second[j])
            {
                merge[k++] = first[i++];
            }
            else
            {
                merge[k++] = second[j++];
            }
        }
        while (i < M)                       // 첫번째 배열이 끝까지 도달할 때까지
        {
            merge[k++] = first[i++];
        }
        while (j < N)                       // 두번째 배열이 끝까지 도달할 때까지
        {
            merge[k++] = second[j++];
        }

        //[3] Output
        for (int index = 0; index < merge.Length; index++)
        {
            Console.Write("{0}\t", merge[index]);
        }
        Console.WriteLine();
    }
}

//int[] first = { 1, 3, 5 };
//int[] second = { 2, 4 };
//var result = (from f in first select f).Union(from s in second select s).OrderBy(x => x).ToArray();
//result
//int[5] { 1, 2, 3, 4, 5 }
