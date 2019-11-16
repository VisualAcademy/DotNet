using System;

static class DynamicExtensionMethod
{
    // 확장 메서드 
    static string PreDotNet(this string str) => $"....{str}";

    static void Main()
    {
        string s1 = "DotNet";
        Console.WriteLine(s1.PreDotNet()); //[1] 실행됨

        dynamic d1 = "Korea";
        Console.WriteLine(d1.PreDotNet()); //[2] 에러 발생
    }
}
