using System;

class StringAndCharArrayConverter
{
    static void Main()
    {
        // 문자열 선언
        string originalString = "Hello";

        // 문자열을 문자 배열로 변환
        char[] charArray = originalString.ToCharArray();
        Console.WriteLine("문자 배열: " + string.Join(", ", charArray));

        // 문자 배열을 다시 문자열로 변환
        string newString = new string(charArray);
        Console.WriteLine("다시 변환된 문자열: " + newString);
    }
}
