using System;

class NullCoalescingOperator
{
    static void Main()
    {
        int? value = null; // null 가능 형식에 null로 초기화
        int defaultValue = value ?? -1; // value가 null이면 -1 대입
        Console.WriteLine(defaultValue); // -1
    }
}
