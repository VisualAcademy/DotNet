using System;

class MethodOverloading
{
    static void Main()
    {
        int number = 100;
        Print(number);      // 100
        Print(ref number);  // 101
        Print(number);      // 101
    }
    static void Print(int number) => Console.WriteLine(number);
    static void Print(ref int number) => Console.WriteLine(++number);
}
