using System;

class ArraySort
{
    static void Main()
    {
        int[] arr = { 3, 2, 1, 4, 5 };
        Array.Sort(arr); // 정렬
        foreach (var item in arr)
        {
            Console.WriteLine(item);            
        }
    }
}
