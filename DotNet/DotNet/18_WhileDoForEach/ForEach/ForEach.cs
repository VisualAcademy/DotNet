using System;

class ForEach
{
    static void Main()
    {
        string str = "ABC123";

        // 문자열에서 문자 하나씩 뽑아서 출력
        foreach (char c in str)
        {
            Console.Write($"{c}\t");
        }
        Console.WriteLine();
    }
}
