//[?] StringBuilder 클래스의 Append() 메서드로 문자열 연결
using System;
using System.Text;

class StringBuilderClass
{
    static void Main()
    {
        //[1] StringBuilder 클래스의 인스턴스 생성
        StringBuilder sb = new StringBuilder();

        //[2] Append() 메서드로 문자열 추가
        sb.Append("January\n");
        sb.Append("February\n");
        sb.AppendLine("March");

        //[3] ToString() 메서드로 문자열로 출력
        Console.Write(sb.ToString());
    }
}
