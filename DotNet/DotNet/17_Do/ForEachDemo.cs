using System;

class ForEachDemo
{
    static void Main()
    {
        string[] names = { "C#", "ASP.NET" };
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}
