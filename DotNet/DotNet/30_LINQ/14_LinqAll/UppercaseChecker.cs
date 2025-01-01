using System;
using System.Linq;

class UppercaseChecker
{
    static void Main()
    {
        string input = "HELLO";

        // 모든 문자가 대문자인지 확인
        bool allUppercase = input.All(char.IsUpper);

        if (allUppercase)
        {
            Console.WriteLine("모든 문자가 대문자입니다.");
        }
        else
        {
            Console.WriteLine("대문자가 아닌 문자가 포함되어 있습니다.");
        }
    }
}
