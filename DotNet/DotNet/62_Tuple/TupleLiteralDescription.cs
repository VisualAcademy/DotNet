using System;

class TupleLiteralDescription
{
    static void Main()
    {
        Tally();
    }

    static void Tally()
    {
        // Tuple Literal
        var r = (12, 34, 56); // VS2017 => System.ValueTuple.dll 참조
        Console.WriteLine($"{r.Item1}, {r.Item2}, {r.Item3}");
    }
}
