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
