using System;

class CharStruct
{
    static void Main()
    {
        char a = 'A'; char b = 'a';
        char c = '1'; char d = '\t'; // 이스케이프 시퀀스도 하나의 문자로 인식

        if (Char.IsUpper(a)) // 대문자인지?
        {
            Console.WriteLine("{0}은(는) 대문자", a);
        }
        if (Char.IsLower(b)) // 소문자인지?
        {
            Console.WriteLine("{0}은(는) 소문자", b);
        }
        if (Char.IsNumber(c)) // 숫자형인지? 
        {
            Console.WriteLine("{0}은(는) 숫자형", c);
        }
        if (Char.IsWhiteSpace(d)) // 공백 문자인지? 
        {
            Console.WriteLine("{0}은(는) 공백 문자", d);
        }

        Console.WriteLine(Char.ToLower(a)); // A -> a
        Console.WriteLine(Char.ToUpper(b)); // a -> A

        string s = "abc";
        if (Char.IsUpper(s[0])) // 첫문자가 대문자인지?
        {
            Console.WriteLine("첫문자가 대문자로 시작합니다.");
        }
        else
        {
            Console.WriteLine("첫문자가 소문자로 시작합니다.");
        }

        Console.WriteLine(Char.MinValue); // 문자의 최솟값
        Console.WriteLine(Char.MaxValue); // 문자의 최댓값
    }
}
