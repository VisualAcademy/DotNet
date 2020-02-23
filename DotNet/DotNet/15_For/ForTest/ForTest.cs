using System;

public class ForTest
{
    public static void Main(string[] args)
    {
        // for문(구간반복) : 초기식;조건식(최종값);증감식
        for (int i = 0; i < 5; i++)
        {
            if (i == 3)
            {
                Console.WriteLine("3 찾음");
            }
        }

        Console.ReadLine();
    }
}
