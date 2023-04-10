using System;

class SequentialSearchExample
{
    static void Main()
    {
        int i;
        int[] data = { 1, 3, 5, 7, 9, 11 };
        int search = 0;
        int n = data.Length;
        bool flag = false;

        Console.Write("검색할 정수(1~20): ");
        search = int.Parse(Console.ReadLine());

        for (i = 0; i < n; i++)
        {
            if (search == data[i])
            {
                flag = true;
            }
        }

        if (flag == true)
        {
            Console.WriteLine("{0}을(를) 찾았습니다.", search);
        }
        else
        {
            Console.WriteLine("{0}을(를) 못 찾았습니다.", search);
        }
    }
}
