using System;

public class Page
{
    public string Message { get; private set; } = "읽기 전용 속성";
}

class PropertyPrivateSet
{
    static void Main()
    {
        Page page = new Page();
        //page.Message = "외부에서 쓰기 불가능";
        Console.WriteLine(page.Message); // 읽기 전용 속성
    }
}
