using System;

class ForSum
{
    static void Main()
    {
        int n = 3; 
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            sum = sum + i; // SUM
        }

        Console.WriteLine($"1부터 {n}까지의 합: {sum}");
    }
}
