using System;

class As
{
    static void Main()
    {
        object x = 1234;         
        string s = x as string;
        Console.WriteLine(s == null ? "null" : s);
    }
}
