using System;

class SumOfMultiplesOfSeven
{
    static void Main()
    {
        int i = 1, sum = 0;

        while (i <= 50)
        {
            if (i % 7 == 0)
            {
                sum += i;
            }
            i++;
        }

        Console.WriteLine(sum);
    }
}
