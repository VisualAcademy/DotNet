using System;

class MinMax
{
    static void Main()
    {
        int[] arr = new int[3];
        Console.WriteLine("배열의 요소를 입력하세요.");
        for (int i = 0; i < 3; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int min = arr[0], max = arr[0];
        for (int i = 1; i < 3; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        Console.WriteLine("최소값: " + min);
        Console.WriteLine("최대값: " + max);
    }
}
