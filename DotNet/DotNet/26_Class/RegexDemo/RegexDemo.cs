using System;
using System.Text.RegularExpressions;

class RegexDemo
{
    static void Main()
    {
        // 정규 표현식 관련 클래스: Regex
        string email = "abcd@aaa.com";
        Console.WriteLine(IsEmail(email));
    }

    static bool IsEmail(string email)
    {
        bool result = false;

        Regex regex = new Regex(
            @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)" +
            @"(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

        result = regex.IsMatch(email); // 패턴이 맞으면 True

        return result;
    }
}
