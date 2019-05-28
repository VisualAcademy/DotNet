using System;

class ForIncrement
{
    static void Main()
    {
        // 0부터 4까지 2씩 증가
        for (int i = 0; i < 5; i = i + 2)
        {
            Console.WriteLine(i); // 0, 2, 4
        }
    }
}
