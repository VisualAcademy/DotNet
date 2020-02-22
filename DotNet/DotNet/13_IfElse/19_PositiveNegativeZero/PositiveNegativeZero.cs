//[?] 정수를 양의 정수, 0, 음의 정수로 판단하기(else if)
using System;

class PositiveNegativeZero
{
    static void Main()
    {
        int number = -10; //[1] 원하는 정수 데이터 입력

        if (number > 0) //[A] 양수 판단
        {
            Console.WriteLine($"{number}은 양수입니다.");
        }
        else if (number < 0) //[B] 음수 판단
        {
            Console.WriteLine($"{number}은 음수입니다."); // *
        }
        else
        {
            Console.WriteLine($"{number}은 0입니다.");
        }
    }
}
