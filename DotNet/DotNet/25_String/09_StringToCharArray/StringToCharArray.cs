//[?] ToCharArray() 메서드로 문자열을 문자 배열로 변환하기
using System;

class StringToCharArray
{
    static void Main()
    {
        string s = "Hello.";
        char[] ch = s.ToCharArray(); // 문자열을 문자 배열로 변환
        for (int i = 0; i < ch.Length; i++)
        {
            Console.Write($"{ch[i]}\t"); 
        }
        Console.WriteLine();
    }
}
