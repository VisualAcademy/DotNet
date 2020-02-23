using System;

class SwitchPractice
{
    static void Main()
    {
        int f = Convert.ToInt32(Console.ReadLine()); // 3
        char o = Convert.ToChar(Console.ReadLine()); // +, -, *
        int s = Convert.ToInt32(Console.ReadLine()); // 5

        switch (o)
        {
            case '+':
                Console.WriteLine($"{f} {o} {s} = {f + s}");
                break;
            case '-':
                Console.WriteLine($"{f} {o} {s} = {f - s}");
                break;
            case '*':
                Console.WriteLine($"{f} {o} {s} = {f * s}");
                break;
            default:
                Console.WriteLine("+, -, *만 사용하세요.");
                break;
        }
    }
}
