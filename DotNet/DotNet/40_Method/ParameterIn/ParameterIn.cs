using System;

class ParameterIn
{
    static void Main()
    {
        int num = 10;
        Console.WriteLine($"[1] {num}"); // [1] 10

        Do(num);

        Console.WriteLine($"[3] {num}"); // [3] 10
    }

    static void Do(int num)
    {
        num = 20;
        Console.WriteLine($"[2] {num}"); // [2] 20
    }
}
