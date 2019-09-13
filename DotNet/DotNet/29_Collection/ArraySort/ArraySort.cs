using System;

class ArraySort
{
    static void Main()
    {
        int[] arr = { 3, 2, 1, 4, 5 };
        Array.Sort(arr); // 오름차순 정렬: 1, 2, 3 순서
        foreach (var item in arr)
        {
            Console.WriteLine(item);            
        }
    }
}
