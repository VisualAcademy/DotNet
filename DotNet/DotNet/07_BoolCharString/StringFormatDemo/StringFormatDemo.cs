// String.Format() 메서드: 문자열 연결 관련 주요 기능 제공
using System;

class StringFormatDemo
{
    static void Main()
    {
        string msg = string.Format("{0}님, {1}", "홍길동", "안녕하세요.");
        Console.WriteLine(msg); // 홍길동님, 안녕하세요.
    }
}
