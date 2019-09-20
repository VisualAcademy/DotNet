using System;

class ObjectToString
{
    static void Main()
    {
        object x = 1234;
        string s = x as string;
        Console.WriteLine(s);

        object x2 = "1234";
        string s2 = x2 as string;
        Console.WriteLine(s2);
    }
}
