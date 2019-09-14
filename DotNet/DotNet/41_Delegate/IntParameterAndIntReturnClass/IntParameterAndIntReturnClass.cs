using System;

class IntParameterAndIntReturnClass
{
    delegate int IntParameterAndIntReturnDelegate(int x);

    static void Main()
    {
        IntParameterAndIntReturnDelegate pow = (x) => x * x;
        Console.WriteLine(pow(3));
    }
}
