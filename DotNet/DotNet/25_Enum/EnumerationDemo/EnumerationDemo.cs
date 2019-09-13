using System;

// 우선순위를 묶어서 관리할 수 있는 Priority 열거형 생성
enum Priority
{
    High,
    Normal,
    Low
}

class EnumerationDemo
{
    static void Main()
    {
        Priority high = Priority.High; // 인텔리센스의 도움 받을 수 있어 편리함
        Priority normal = Priority.Normal;
        Priority low = Priority.Low;

        Console.WriteLine($"{high}, {normal}, {low}");
    }
}
