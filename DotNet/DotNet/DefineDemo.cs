#define YES

using System;

class DefineDemo
{
    static void Main()
    {
#if YES
        Console.WriteLine("YES");
#else
        Console.WriteLine("NO");
#endif
    }
}
