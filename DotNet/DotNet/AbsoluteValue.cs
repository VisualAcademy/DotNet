﻿//[?] 3항 연산자(조건 연산자)를 사용하여 절댓값 구하기 
using System;

class AbsoluteValue
{
    static void Main()
    {
        int num = -21;
        int abs = (num < 0) ? -num : num; // 3항 연산자로 음수만 부호 변환
        Console.WriteLine($"{num}의 절댓값: {abs}");
    }
}
