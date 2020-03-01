//[?] var 키워드: 암시적으로 형식화된 로컬 변수
using System;

class Var
{
    static void Main()
    {
        var name = "C#"; // string 형식으로 변환해줌
        Console.WriteLine(name); // C#

        var version = 8.0; // double 형식으로 변환해줌
        Console.WriteLine("{0:0.0}", version); // 8.0
    }
}
