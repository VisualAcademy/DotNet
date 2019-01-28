// 익명 형식(Anonymous Type): 익명(무명) 클래스(Anonymous Class)
using System;

class AnonymousClass
{
    static void Main()
    {
        // 익명 형식으로 개체를 생성하고 3개의 속성을 초기화
        var presenter = new { Name = "박용준", Age = 45, Topic = "C#" };

        // 개체 출력
        Console.WriteLine(
            $"{presenter.Name}, {presenter.Age}, {presenter.Topic}");
    }
}
