// is 연산자로 형식(타입) 비교하기 
using System;

class Is
{
    static void Main()
    {
        object x = 1234;

        if (x is int)
        {
            Console.WriteLine($"{x}는 정수형으로 변환이 가능합니다.");
        }
    }
}
