// 논리 연산자: && -> 논리 AND: 양쪽 다 모두 참일 때에만 참
using System;

class LogicalAnd
{
    static void Main()
    {
        // && 연산자: AND
        Console.WriteLine($"true  && true  -> {true && true}  "); // true
        Console.WriteLine($"true  && false -> {true && false} "); // false
        Console.WriteLine($"false && true  -> {false && true} "); // false
        Console.WriteLine($"false && false -> {false && false}"); // false
    }
}
