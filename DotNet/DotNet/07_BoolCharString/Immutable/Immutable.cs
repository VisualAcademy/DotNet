using System;

class Immutable
{
    static void Main()
    {
        // 상수: 변하지 않는 값
        const string name = "백두산";

        // 변수: 변하는 값
        int age = 102;

        // 이름: 백두산, 나이: 102
        Console.WriteLine($"이름: {name}, 나이: {age}");
    }
}
