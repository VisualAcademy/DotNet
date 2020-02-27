#define YES // #define NO

using System;

class DefineDemo
{
    static void Main()
    {
#if YES
        // #define YES가 정의되어 있으면 현재 구문 실행
        Console.WriteLine("YES");
#else
        Console.WriteLine("NO");
#endif
    }
}
