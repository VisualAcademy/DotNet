// <예제>열거형의 값을 정수형이나 문자열로 사용: EnumIndex.cs
using System;

namespace EnumIndex
{
    enum Animal { Rabbit, Dragon, Snake }

    class EnumIndex
    {
        static void Main()
        {
            Animal animal = Animal.Dragon;
            int num = (int)animal; // 1
            string str = animal.ToString(); // "Dragon"
            Console.WriteLine($"Animal.Dragon : {num}, {str}");
        }
    }
}
