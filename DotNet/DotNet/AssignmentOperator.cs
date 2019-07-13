//[?] 할당(대입) 연산자: 변수에 특정 값으로 초기화하면 자동 유추에 의해서 형식이 결정됨
using System;

class AssignmentOperator
{
    static void Main()
    {
        var name = "C#"; // name 변수에 문자열을 대입합니다. 
        var version = 8.0; // version 변수에 숫자를 대입합니다. 

        Console.WriteLine($"{name} {version}");
    }
}
