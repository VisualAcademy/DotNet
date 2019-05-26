//[?] foreach문 : 배열/컬렉션 데이터 구조로부터 데이터를 읽어오는 구문
using System;

public class 배열반복
{
    public static void Main()
    {
        //[1] 문자열 변수 선언
        // 문자열은 문자의 배열(집합/컬렉션)입니다.
        string s = "안녕하세요.";
        Console.WriteLine(s);

        for (int i = 0; i < s.Length; i++)
        {
            Console.Write("{0}\t", s[i]);
        }
        Console.WriteLine();

        //[2] 문자열 중에서 문자 하나씩 뽑아서 출력
        foreach (char c in s)
        {
            Console.Write("{0}\t", c);
        }
        Console.Write('\n');
    }
}
