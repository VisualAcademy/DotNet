using System;

class ArrayWithVarKeyword
{
    static void Main()
    {
        // 정수 형식으로 자동적으로 형식이 설정됨
        var i = 5; // int i = 5; 
        Console.WriteLine("i : {0}, 타입 : {1}", i, i.GetType());

        // 문자열 형식으로 형식화됨
        var s = "Hello";
        Console.WriteLine("s : {0}, 타입 : {1}", s, s.GetType());

        // 배열 형식
        var numbers = new int[] { 1, 2, 3 };

        // 여기서 var item은 numbers 배열의 요소의 형식, 즉 int 형식임
        foreach (var item in numbers) 
        {
            Console.WriteLine("item : {0}, 타입 : {1}", item, item.GetType());
        }
    }
}
