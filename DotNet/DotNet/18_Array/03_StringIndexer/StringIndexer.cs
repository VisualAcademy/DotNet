//[?] 문자열 인덱서: 문자열에 직접 인덱서([]) 사용하기 
using System;

class StringIndexer
{
    static void Main()
    {
        Console.WriteLine("ABC"[0]); // 'A'
        Console.WriteLine("ABC"[1]); // 'B'
        Console.WriteLine("ABC"[2]); // 'C'

        Console.WriteLine("ABC".GetType()); // System.String
        Console.WriteLine("ABC"[0].GetType()); // System.Char
    }
}
