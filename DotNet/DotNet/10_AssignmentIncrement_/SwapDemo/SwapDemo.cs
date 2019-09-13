using System;

class SwapDemo
{
    static void Main()
    {
        var i = 100;
        var j = 200;

        Console.WriteLine($"처음: {i}, {j}");

        // 변숫값 서로 바꾸기
        var temp = i; //[A] 임시 변수에 i 값 담기
        i = j; //[B] i 값에 j 값으로 덮어쓰기
        j = temp; //[C] j에 i 값이 담겨 있던 temp값으로 덮어쓰기

        Console.WriteLine($"변경: {i}, {j}");
    }
}
