using System;
using System.Diagnostics;

class ProcessGetCurrentProcess
{
    static void Main()
    {
        Console.WriteLine(Process.GetCurrentProcess().ProcessName);
    }
}
