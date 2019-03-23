using System;
using static System.Console;

class TupleDeconstructionDescription
{
    static void Main()
    {
        // 튜플 해체(Tuple Deconstruction)
        var (sum, count) = Tally();
        WriteLine($"Sum: {sum}, Count: {count}");
    }

    static (int Sum, int Count) Tally()
    {
        var r = (s: 12, c: 3);

        Console.WriteLine($"{r.s}, {r.c}");

        return r;
    }
}
