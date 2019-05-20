using System;

class Pair<T, V>
{
    private T _first;
    private V _second;

    public Pair(T first, V second)
    {
        _first = first;
        _second = second; 
    }

    public void PrintMember()
    {
        Console.WriteLine($"{this._first} {this._second}");
    }
}

class Generic_PairOfType
{
    static void Main()
    {
        Pair<string, bool> dev = new Pair<string, bool>("Developer?", true);
        dev.PrintMember(); 
    }
}
