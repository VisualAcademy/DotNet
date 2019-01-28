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
