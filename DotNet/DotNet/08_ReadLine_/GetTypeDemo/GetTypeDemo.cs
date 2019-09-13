// GetType() 메서드: 모든 값의 데이터 형식을 반환
using System;

class GetTypeDemo
{
    static void Main()
    {
        int i = 1234;               // 정수
        string s = "안녕하세요.";    // 문자열
        char c = 'A';               // 문자
        double d = 3.14;            // 실수
        object o = new Object();    // 개체: 개체 생성하는 구문

        Console.WriteLine(i.GetType()); // System.Int32
        Console.WriteLine(s.GetType()); // System.String
        Console.WriteLine(c.GetType()); // System.Char
        Console.WriteLine(d.GetType()); // System.Double
        Console.WriteLine(o.GetType()); // System.Object
    }
}
