using System;

class CharacterEscapeSequence
{
    static void Main()
    {
        char ch1 = 'A';
        char ch2 = 'B';
        char newLine = '\n'; // \n: 줄 바꿈 문자
        Console.WriteLine("{0}{1}{2}", ch1, newLine, ch2);
    }
}
