#define RELEASE
using System;
using System.Diagnostics;

public class ConditionalDemo
{
    static void Main()
    {
        DebugMethod();
        ReleaseMethod();
    }

    [Conditional("DEBUG")]
    static void DebugMethod() => Console.WriteLine("디버그 환경에서만 표시");
    [Conditional("RELEASE")] static void ReleaseMethod() => Console.WriteLine("릴리스 환경에서만 표시");
}
