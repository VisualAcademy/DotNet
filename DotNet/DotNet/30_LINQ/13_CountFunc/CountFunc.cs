using System;
using System.Linq;

class CountFunc
{
    static void Main()
    {
        bool[] blns = { true, false, true, false, true };

        Console.WriteLine(blns.Count()); // 5
        Console.WriteLine(blns.Count(bln => bln == true)); // 3
        Console.WriteLine(blns.Count(bln => bln == false)); // 2
    }
}
