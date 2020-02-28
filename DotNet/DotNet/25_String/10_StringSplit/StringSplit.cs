//[?] Split() 메서드로 문자열 분리하기
using System;

class StringSplit
{
    static void Main()
    {
        string src = "Red,Green,Blue";

        // 문자열에서 특정 구분자를 사용하여 문자열 배열 만들기
        string[] colors = src.Split(',');

        for (int i = 0; i < colors.Length; i++)
        {
            Console.WriteLine(colors[i]);
        }
    }
}
