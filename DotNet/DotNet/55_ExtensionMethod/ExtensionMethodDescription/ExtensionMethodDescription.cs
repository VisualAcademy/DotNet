using System;
using System.Text;

/// <summary>
/// static 클래스
/// </summary>
public static class ExtensionMethodClass
{
    /// <summary>
    /// static 메서드
    /// </summary>
    public static StringBuilder AppendCheck(
        this StringBuilder sb,
        bool isCheck) => isCheck ? sb.Append(" checked ") : sb;
}

class ExtensionMethodDescription
{
    static void Main()
    {
        string checkBox = new StringBuilder()
            .AppendFormat("<input type=\"{0}\"", "checkbox")
            .AppendCheck(true) // true를 주면 checked 문자열이 포함되어 출력
            .Append("/>").ToString();
        Console.WriteLine(checkBox);
    }
}
