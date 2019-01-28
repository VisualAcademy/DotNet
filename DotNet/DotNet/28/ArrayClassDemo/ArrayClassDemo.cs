using System;

class ArrayClassDemo
{
    static void Main()
    {
        int[] arr = { 1, 2, 3 };
        Array.Reverse(arr); // 배열을 역순으로 변환
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }
}
