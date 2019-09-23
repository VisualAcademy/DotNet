//[?] 익명 형식(Anonymous Type): 클래스없이 개체를 만드는 방법 
using System;

class ObjectDemo
{
    static void Main()
    {
        //[1] 개체(Object) 만들기: 익명 형식(Anonymous Type)
        var hong = new { Name = "홍길동", Age = 21 };
        var park = new { Name = "박문수", Age = 30 };

        //[2] 개체 사용하기
        Console.WriteLine($"이름: {hong.Name}, 나이: {hong.Age}");
        Console.WriteLine($"이름: {park.Name}, 나이: {park.Age}");
    }
}
