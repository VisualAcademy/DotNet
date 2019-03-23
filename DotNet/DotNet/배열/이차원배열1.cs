using System;

class 이차원배열1
{
    static void Main()
    {
        int[,] intArray; // 2차원 배열 선언
        intArray = new int[2, 3]; // 2 * 3개의 요소 생성

        intArray[0, 0] = 1; // 2차원 배열 초기화
        intArray[0, 1] = 2;
        intArray[0, 2] = 3;
        intArray[1, 0] = 4;
        intArray[1, 1] = 5;
        intArray[1, 2] = 6;

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
