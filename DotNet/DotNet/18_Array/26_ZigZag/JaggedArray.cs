// JaggedArray.cs
using System;

public class JaggedArray
{
    static void Main()
    {
        // Jagged array 생성, 3개의 다른 크기의 배열을 가진다.
        int[][] jaggedArray = new int[3][];

        jaggedArray[0] = new int[5] { 1, 2, 3, 4, 5 }; // 첫 번째 배열은 5개의 요소를 가짐
        jaggedArray[1] = new int[3] { 6, 7, 8 };       // 두 번째 배열은 3개의 요소를 가짐
        jaggedArray[2] = new int[4] { 9, 10, 11, 12 }; // 세 번째 배열은 4개의 요소를 가짐

        // Jagged array의 모든 요소를 출력
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
