// 2개의 수를 입력한 후 그 중에서 큰 수를 출력하는 프로그램
using System;

class GreaterThanEqual
{
    static void Main()
    {
        Console.Write("첫 번째 수: ");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.Write("두 번째 수: ");
        int second = Convert.ToInt32(Console.ReadLine());

        if (first >= second)
        {
            Console.WriteLine("큰 값: {0}", first);
        }
        else
        {
            Console.WriteLine("큰 값: {0}", second);
        }
    }
}
