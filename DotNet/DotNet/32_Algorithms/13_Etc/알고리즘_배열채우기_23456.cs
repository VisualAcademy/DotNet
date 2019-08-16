using System;

class 알고리즘_배열채우기_23456
{
    static void Main()
    {
        int[,] arr = new int[5, 5];
        int p = 0; // 행 인덱스
        int q = 0; // 열 인덱스

        do
        {
            p = p + 1;
            q = 0;
            do
            {
                q = q + 1;
                arr[p - 1, q - 1] = q + 1;
            } while (q < p);
        } while (p < 5);

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write("{0}\t", arr[i, j]);
            }
            Console.WriteLine();
        }
    }
}

