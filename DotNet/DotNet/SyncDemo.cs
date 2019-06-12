using System;

class SyncDemo
{
    static void Sum(int a, int b) => Console.WriteLine($"{a} + {b} = {a + b}");
    static void Main()
    {
        Sum(3, 5); // Sum() 메서드는 호출한 순서대로 실행됩니다. 
        Sum(5, 7);
        Sum(7, 9);
    }
}
