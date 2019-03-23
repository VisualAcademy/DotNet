using System;

class ObjectDemo
{
    static void Main()
    {
        // 개체(Object) 만들기: 익명 형식(Anonymous Type)
        var hong = new { Name = "홍길동", Age = 21 };
        var park = new { Name = "박문수", Age = 30 };

        // 개체 사용하기
        Console.WriteLine($"이름: {hong.Name}, 나이: {hong.Age}");
        Console.WriteLine($"이름: {park.Name}, 나이: {park.Age}");
    }
}
