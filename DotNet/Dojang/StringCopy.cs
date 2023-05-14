using System;

class StringCopy
{
    static void Main()
    {
        Console.Write("원본 문자열을 입력하세요: ");
        string src = Console.ReadLine();

        string dest = String.Copy(src);

        Console.WriteLine("복사된 문자열: " + dest);
    }
}
