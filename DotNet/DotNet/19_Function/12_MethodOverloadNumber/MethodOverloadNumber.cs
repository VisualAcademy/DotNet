// MethodOverloadNumber.cs
// 메서드(함수) 오버로드(다중 정의) 
using System;

class MethodOverloadNumber
{
    // GetNumber 함수: int 매개 변수
    static void GetNumber(int number)
    {
        Console.WriteLine($"Int32: {number}");
    }

    // GetNumber 함수: long 매개 변수
    static void GetNumber(long number)
    {
        Console.WriteLine($"Int64: {number}");
    }

    static void Main()
    {
        GetNumber(1234);    // Int32: 1234
        GetNumber(1234L);   // Int64: 1234
    }
}
