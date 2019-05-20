using System;

class DuckTyping
{
    static void Main()
    {
        var duck = new { Id = 1, Name = "Duck 1" };
        Console.WriteLine($"{duck.Id} - {duck.Name}");

        duck = new { Id = 2, Name = "Duck 2" };
        Console.WriteLine($"{duck.Id} - {duck.Name}");

        //duck = new { Id = 3.14, Name = "Duck 3" };
        //duck = new { Id = 3 };
        //duck = new { Id = 3, Name = "Duck 3", Email = "Email 3" };

        duck = new { Id = 3, Name = "Duck 3" };
        Console.WriteLine($"{duck.Id} - {duck.Name}");
    }
}
