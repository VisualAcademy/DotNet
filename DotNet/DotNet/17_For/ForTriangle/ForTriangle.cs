using System;

class ForTriangle
{
    static void Main()
    {
        // 행 반복
        for (int i = 1; i <= 5; i++)
        {
            // 열 반복
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*"); 
            }
            Console.WriteLine();
        }
    }
}
