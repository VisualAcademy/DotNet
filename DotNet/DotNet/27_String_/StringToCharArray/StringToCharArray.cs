//[?] ToCharArray() 메서드로 문자열을 문자 배열로 변환하기
using System;

class StringToCharArray
{
    static void Main()
    {
        string s = "안녕하세요.";
        char[] ch = s.ToCharArray();
        for (int i = 0; i < ch.Length; i++)
        {
            Console.WriteLine(ch[i]); // '안', ..., '.'
        }
    }
}
