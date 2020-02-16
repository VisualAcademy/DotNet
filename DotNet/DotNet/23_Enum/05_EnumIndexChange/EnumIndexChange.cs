// <예제>열거형의 인덱스 순서 변경: EnumIndexChange.cs
using System;

enum Animal
{
    Horse,      // 0
    Sheep = 5,  // 1 => 5
    Monkey      // 2 => 6
}

class EnumIndexChange
{
    static void Main()
    {
        Console.WriteLine((int)Animal.Monkey); // 6
    }
}
