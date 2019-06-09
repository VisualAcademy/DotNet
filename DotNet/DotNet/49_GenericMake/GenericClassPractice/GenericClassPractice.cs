using System;

public class Multi<T>
{
    public T Data { get; set; }
}

class GenericClassPractice
{
    static void Main()
    {
        Multi<string> title = new Multi<string>();
        title.Data = "연봉";

        Multi<long> income = new Multi<long>();
        income.Data = 100_000_000;

        Console.WriteLine($"{title.Data}: {income.Data:#,###}");
    }
}
