using System;

class TupleReturnName
{
    static void Main()
    {
        var t = NameTuple();
        Console.WriteLine($"{t.first}, {t.second}");
    }

    static (int first, int second) NameTuple()
    {
        var r = (100, 200);
        return r;
    }
}
