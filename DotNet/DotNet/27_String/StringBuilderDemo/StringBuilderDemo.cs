//[?] StringBuilder 클래스: 문자열 처리 관련 여러 메서드 제공
using System;
using System.Text;

class StringBuilderDemo
{
    static void Main()
    {
        //[!] StringBuilder 클래스: 긴 문자열 묶을 때 효과적
        StringBuilder sb = new StringBuilder();

        sb.Append("<script>");
        sb.AppendFormat("window.alert(\"{0}\");", DateTime.Now.Year);
        sb.AppendLine("</script>");

        Console.WriteLine(sb.ToString());
    }
}
