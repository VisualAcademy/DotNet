using System;

class VariableSameValue
{
    static void Main()
    {
        int a, b, c;

        //[1] 여러 개의 변수를 선언하고 같은 값으로 초기화하기
        a = b = c = 10;

        Console.WriteLine("{0}, {1}, {2}", a, b, c);
    }
}
