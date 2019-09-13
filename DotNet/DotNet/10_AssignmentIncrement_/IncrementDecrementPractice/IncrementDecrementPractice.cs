// 연습문제: 증가, 감소 연산자 사용하기 
using System;

class IncrementDecrementPractice
{
    static void Main()
    {
        int number1 = 3; //[1]
        int number2 = 5; //[2]

        int result1 = 0;
        int result2 = 0;

        number1--; // 1감소
        result1 = ++number1; // 1증가

        ++number2; // 1증가
        result2 = number2--; 

        Console.WriteLine(result1); // 3
        Console.WriteLine(result2); // 6
    }
}
