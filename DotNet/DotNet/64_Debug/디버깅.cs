using System;

class 디버깅
{
    static void Main(string[] args)
    {
        //[1] Input
        int sum = 0;
        //[2] Process
        //for (int i = 1; i <= 100; i++)
        //{
        //    if (i % 3 == 0 || i % 4 == 0)
        //    {
        //        sum += i;
        //    }
        //}
        sum = GetData(sum);
        //[3] Output
        Console.WriteLine(
            "1부터 100까지 3의 배수 또는 4의 배수의 합 : {0}", sum);
    }

    private static int GetData(int sum)
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 || i % 4 == 0)
            {
                sum += i;
            }
        }
        return sum;
    }
}
