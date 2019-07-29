// 논리 연산자: || -> 논리 OR: 하나라도 참이면 참
using System;

class LogicalOr
{
    static void Main()
    {
        // || 연산자: OR
        Console.WriteLine($"true  || true  -> {true || true}  "); // true
        Console.WriteLine($"true  || false -> {true || false} "); // true
        Console.WriteLine($"false || true  -> {false || true} "); // true
        Console.WriteLine($"false || false -> {false || false}"); // false
    }
}
