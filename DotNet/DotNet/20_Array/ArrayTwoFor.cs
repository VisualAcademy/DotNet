// 2차원 배열을 2중 for 문으로 반복해서 출력하기 
using System;

class ArrayTwoFor
{
    static void Main()
    {
        int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 } };
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"arr[{i},{j}] = {arr[i, j]}");
            }
        }
    }
}
