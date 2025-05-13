using System;

class ArrayWithVarKeyword
{
    static void Main()
    {
        // var를 사용하면 컴파일 시 형식이 자동으로 결정됨
        var i = 5; // 컴파일러가 int 형식으로 추론
        Console.WriteLine("i : {0}, 타입 : {1}", i, i.GetType());

        // 문자열 리터럴이므로 string 형식으로 추론됨
        var s = "Hello";
        Console.WriteLine("s : {0}, 타입 : {1}", s, s.GetType());

        // 정수형 배열로 추론됨: int[]
        var numbers = new int[] { 1, 2, 3 };

        // foreach에서 var는 요소의 형식(int)을 추론함
        foreach (var item in numbers)
        {
            Console.WriteLine("item : {0}, 타입 : {1}", item, item.GetType());
        }
    }
}
