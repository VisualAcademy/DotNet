using System;

class OutVariableDemo
{
    static void Main()
    {
        if (DateTime.TryParse("2019/12/25", out var xmas))
        {
            Console.WriteLine(xmas);
        }
    }
}
