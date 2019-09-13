// 문자 배열을 문자열로 변환하기 
using System;

class CharArrayToString
{
    static void Main()
    {
        char[] charArray = { 'A', 'B', 'C' };

        String str = new String(charArray);

        Console.WriteLine(str); // "ABC"
    }
}
