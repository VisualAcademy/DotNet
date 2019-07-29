using System;
using System.Text;

class StringBuilderClass
{
    static void Main()
    {
        // StringBuilder 클래스의 인스턴스 생성
        StringBuilder sb = new StringBuilder();
        sb.Append("January\n");
        sb.Append("February\n");
        sb.AppendLine("March");
        Console.Write(sb.ToString());
    }
}
