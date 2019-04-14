using System;
using System.Text.RegularExpressions;

class RegexReplace
{
    static void Main()
    {
        string s = "안녕하세요.    반갑습니다.    또 만나요.";
        var regex = new Regex("\\s+"); // 하나 이상의 공백 패턴 검사
        string r = regex.Replace(s, " "); // 하나 이상의 공백을 공백 하나로 변환
        Console.WriteLine(s);
        Console.WriteLine(r);
    }
}
