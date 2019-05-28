﻿using System;

class LambdaExpressionTypeDeclare
{
    delegate bool Lambda(string msg, int len);
    static void Main()
    {
        Lambda isLong =
            (string msg, int len) => msg.Length > len;
        Console.WriteLine(isLong("안녕하세요.", 5)); // true
        Console.WriteLine(isLong("반갑습니다.", 10)); // false
    }
}
