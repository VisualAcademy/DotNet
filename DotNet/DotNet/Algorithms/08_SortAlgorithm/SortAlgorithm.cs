using System;

class SortAlgorithm
{
    static void Main()
    {
        //[1] Input
        int[] data = { 3, 2, 1, 5, 4 };

        //[2] Process: Selection Sort(선택 정렬) 알고리즘
        int N = data.Length;
        for (int i = 0; i < N - 1; i++)
        {
            for (int j = i + 1; j < N; j++)
            {
                if (data[i] > data[j])
                {
                    int temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                }
            }
        }

        //[3] Output
        for (int i = 0; i < data.Length; i++)
        {
            Console.Write($"{data[i]} ");
        }
        Console.WriteLine();
    }
}

//int[5] { 3, 2, 1, 5, 4 }
//Array.Sort(data);
//data
//int[5] { 1, 2, 3, 4, 5 }

//var sort = data.OrderBy(n => n).ToArray();
//sort
//int[5] { 1, 2, 3, 4, 5 }
