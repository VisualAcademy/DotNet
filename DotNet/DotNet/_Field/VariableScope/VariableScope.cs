using System;

class VariableScope
{
    static string globalVariable = "전역 변수"; // 필드 또는 멤버 변수

    static void Main()
    {
        //[1]
        string localVariable = "지역 변수";
        Console.WriteLine(localVariable);

        //[2][1]
        Console.WriteLine(globalVariable); // "전역 변수"

        //[2][2]
        Test();
    }

    static void Test() => Console.WriteLine(globalVariable); // "전역 변수"
}
