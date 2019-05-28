//[?] 2차원 배열
// 다차원(2차원 이상) 배열 선언
// 데이터형식[,] 배열이름; // 2차원 배열
// 데이터형식[,,] 배열이름; // 3차원 배열
using System;

class TwoDimensionalArray
{
    static void Main()
    {
        // 배열 선언
        int[] oneArray;         // 1차원 배열 선언
        int[,] twoArray;        // 2차원 배열 선언
        int[,,] threeArray;     // 3차원 배열 선언

        // 배열 초기화: 배열이름 = new 데이터형식[요소수, 요소수];
        oneArray = new int[2] { 1, 2 };
        twoArray = new int[2, 2] { { 1, 2 }, { 3, 4 } };
        threeArray = new int[2, 2, 2] { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };

        // 배열 사용
        // 1차원 배열 사용
        for (int i = 0; i < 2; i++)
        {
            Console.Write($"{oneArray[i]}\t");
        }
        Console.WriteLine();

        // 2차원 배열 사용
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write($"{twoArray[i, j]}\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // 3차원 배열 사용
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    Console.Write($"{threeArray[i, j, k]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
