using System;

class VariableInitialize
{
    static void Main()
    {
        //[1] 변수 선언과 초기화를 한 번에 처리 
        int first = 10;

        //[2] 콤마를 사용하여 여러 개의 변수를 동시에 선언 및 초기화
        int second = 20, third = 30;

        Console.WriteLine("{0}, {1}, {2}", first, second, third);
    }
}
