// 더하기(Addtion) 연산자의 추가적인 특징
using System;

class AdditionOperator
{
    static void Main()
    {
        Console.WriteLine("Hello" + "World");
        Console.WriteLine("Hi" + " " + "everyone");
        Console.WriteLine("123" + "456"); // "123456"
        Console.WriteLine("123" + 456); // "123456"
        Console.WriteLine(123 + "456"); // "123456"
        Console.WriteLine(123 + 456); // 산술연산
        Console.WriteLine("123" + true); // 123True
        //Console.WriteLine("123" - 456); // 에러: 문자열에서 정수를 뺄 수 없음
    }
}
