using System;

class TypeConversionError
{
    static void Main()
    {
        long l = long.MaxValue; //[1] long 형식 변수의 가장 큰 값을 l 변수에 저장
        Console.WriteLine($"l의 값: {l}");
        int i = (int)l; //[2] l 변수의 값을 int 형식으로 형식 변환하여 i 변수에 저장
        Console.WriteLine($"i의 값: {i}");
    }
}
//l의 값: 9223372036854775807
//i의 값: -1
//계속하려면 아무 키나 누르십시오. . .
