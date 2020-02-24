using System;

class ArrayMultiPractice
{
    static void Main()
    {
        int[,] grid = new int[2, 3];

        int number = 1;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                grid[i, j] = number++;
            }
        }

        for (int i = 0; i < grid.GetLength(0); i++)
        {
            for (int j = 0; j < grid.GetLength(1); j++)
            {
                Console.Write($"{grid[i, j]}_");
            }
            Console.WriteLine();
        }
    }
}
