using System;
using static System.Console;

class SwitchStatement
{
    static void Main()
    {
        WriteLine("가장 좋아하는 프로그래밍 언어는? ");
        Write("1. C\t");
        Write("2. C++\t");
        Write("3. C#\t");
        Write("4. Java\n");

        int choice = Convert.ToInt32(ReadLine());

        switch (choice)
        {
            case 1:
                WriteLine("C언어 선택");
                break;
            case 2:
                WriteLine("C++ 선택");
                break;
            case 3:
                WriteLine("C# 선택");
                break;
            case 4:
                WriteLine("Java 선택");
                break;
            default:
                WriteLine("C, C++, C#, Java가 아니군요.");
                break;
        }
    }
}
