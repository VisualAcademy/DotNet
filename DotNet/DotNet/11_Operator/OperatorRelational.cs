using System;

class OperatorRelational
{
    static void Main()
    {
        int x = 3;
        int y = 5;

        Console.WriteLine(x == y);  // 3 == 5 -> false
        Console.WriteLine(x != y);  // 3 != 5 -> true
        Console.WriteLine(x > y);   // 3 > 5 -> false
        Console.WriteLine(x >= y);  // 3 >= 5 -> false
        Console.WriteLine(x < y);   // 3 < 5 -> true
        Console.WriteLine(x <= y);  // 3 <= 5 -> true
    }
}
