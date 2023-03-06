using System;

class ReverseTriangle
{
    static void Main(string[] args)
    {
        for (int i = 10; i >= 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
