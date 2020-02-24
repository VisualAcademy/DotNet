using System;

class ArrayGetLengthDemo
{
    static void Main()
    {
        // 3차원 배열 선언/요소수생성/초기화: 층/행/열
        int[,,] arr = new int[2, 2, 2] 
            { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };
        // 차수 출력
        Console.WriteLine("차수 출력: {0}", arr.Rank);
        // 길이 출력
        Console.WriteLine("길이 출력: {0}", arr.Length);
        // 층(면), 행, 열 구분해서 출력
        for (int i = 0; i < arr.GetLength(0); i++)//층
        {
            for (int j = 0; j < arr.GetLength(1); j++)//행
            {
                for (int k = 0; k < arr.GetLength(2); k++)//열
                {
                    Console.Write("{0}\t", arr[i, j, k]);
                }
                Console.WriteLine(); //줄바꿈
            }
            Console.WriteLine(); //줄바꿈
        }
    }
}
