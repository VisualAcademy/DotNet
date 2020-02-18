// String Interpolation(문자열 보간법)
using System;

class StringInterpolationDemo
{
    static void Main()
    {
        string name = "C#";
        string version = "8.0";

        // WriteLine() 메서드의 기본 제공 기능 사용
        Console.WriteLine("{0} {1}", name, version);

        // String.Format() 메서드 사용
        string result = String.Format("{0} {1}", name, version);
        Console.WriteLine(result);

        // 문자열 보간법(String Interpolation) 사용
        Console.WriteLine($"{name} {version}");

        // C# Interactive에서는 Console.WriteLine() 생략 가능
        // $"{name} {version}"
    }
}
