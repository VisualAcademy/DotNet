// 명령줄 인수(애플리케이션 인수)
using System;

class CommandLineArgument
{
    static void Main(string[] args)
    {
        foreach (string arg in args)
        {
            Console.WriteLine(arg);
        }
    }
}
