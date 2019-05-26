using System;

class ArrayThree
{
    static void Main()
    {
        int[,,] intArray = new int[2, 3, 4] 
        { 
            // 0층
            { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } }, 
            // 1층
            { { 13, 14, 15, 16 }, { 17, 18, 19, 20 }, { 21, 22, 23, 24 } }
        };

        for (int i = 0; i < 2; i++) // 층 반복
        {
            for (int j = 0; j < 3; j++) // 행 반복
            {
                for (int k = 0; k < 4; k++) // 열 반복
                {
                    Console.Write("{0,2} ", intArray[i, j, k]);
                }
                Console.Write("\n");
            }
            Console.WriteLine();
        }
    }
}
