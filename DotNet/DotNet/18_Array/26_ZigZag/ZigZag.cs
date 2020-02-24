// 지그재그 배열
// 데이터형식[][] 배열이름;
// int[][] zagArray; 
using System;

class ZigZag
{
    static void Main()
    {
        // 배열 요소수 생성시 [2][] 형태로 2번째를 비워두면 동적으로 n개의 자료로 초기화 가능
        int[][] zagArray = new int[2][];

        zagArray[0] = new int[] { 1, 2 }; // 0번째 행에 2개의 요소로 초기화
        zagArray[1] = new int[] { 3, 4, 5 }; // 1번째 행에 3개의 요소로 초기화 

        for (int i = 0; i < 2; i++)
        {
            // n번째 행의 길이만큼 반복: 2번, 3번 반복
            for (int j = 0; j < zagArray[i].Length; j++)
            {
                Console.Write($"{zagArray[i][j]}\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
