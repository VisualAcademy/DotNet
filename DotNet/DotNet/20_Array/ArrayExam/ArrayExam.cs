using System;

class ArrayExam
{
    static void Main()
    {
        int[] x = { 1, 2, 3 };
        int[] y = { 4, 5, 6 };
        int[] z = new int[3];

        for (int i = 0; i < 3; i++)
        {
            z[i] = x[i] * y[i];
            Console.Write($"z[{i}] = {z[i]}\t");
        }
        Console.WriteLine();
    }
}
