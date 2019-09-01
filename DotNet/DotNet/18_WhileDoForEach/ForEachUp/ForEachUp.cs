using System;

class ForEachUp
{
    static void Main()
    {
        var str = "ABC123";

        // 문자열에서 문자 하나씩 뽑아서 출력
        foreach (var c in str)
        {
            Console.Write($"{c}\t");
        }
        Console.WriteLine();
    }
}
