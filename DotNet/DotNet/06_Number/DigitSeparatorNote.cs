using System;

class DigitSeparatorNote
{
    static void Main()
    {
        // 세자라미다 콤마로 구분되는 숫자를 표현할 때 언더스코어(_) 문자로 구분 가능
        int number = 1_000_000;
        Console.WriteLine(number);
    }
}
