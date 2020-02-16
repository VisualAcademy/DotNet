// <예제> 열거형과 switch 문 함께 사용: EnumSwitch.cs
using System;

namespace EnumSwitch
{
    enum Animal { Chicken, Dog, Pig }

    class EnumSwitch
    {
        static void Main()
        {
            Animal animal = Animal.Dog;

            switch (animal)
            {
                case Animal.Chicken:
                    Console.WriteLine("닭");
                    break;
                case Animal.Dog:
                    Console.WriteLine("개");
                    break;
                case Animal.Pig:
                    Console.WriteLine("돼지");
                    break;
                default:
                    Console.WriteLine("기본값 설정 영역");
                    break;
            }
        }
    }
}
