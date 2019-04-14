using System;

class EnvironmentExit
{
    static void Main()
    {
        Console.WriteLine("출력됩니다.");

        Environment.Exit(0);

        Console.WriteLine("출력될까요?");
    }
}
