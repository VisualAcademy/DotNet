using System;

class 이차원배열4
{
    static void Main()
    {
        // 2차원 배열 선언과 동시에 초기화
        int[,] intArray = { { 1, 2, 3 }, { 4, 5, 6 } };

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{intArray[i, j]}_");
            }
            Console.Write("\n"); // 행 출력 후 개행
        }
    }
}
