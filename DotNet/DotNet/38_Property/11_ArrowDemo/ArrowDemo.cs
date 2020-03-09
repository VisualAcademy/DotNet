using System;

class Counter
{
    // 필드
    private int count;

    // 속성
    public int Count
    {
        get => count;
        set => count = value;
    }

    // 메서드 
    public void IncreaseCount() => Count++;
}

class ArrowDemo
{
    static Counter counter;
    static void Main()
    {
        counter = new Counter();
        counter.IncreaseCount();
        Console.WriteLine($"카운트: {counter.Count}");
    }
}
