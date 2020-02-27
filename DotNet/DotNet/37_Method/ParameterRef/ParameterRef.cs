using System;

class ParameterRef
{
    static void Main()
    {
        int num = 10;
        Console.WriteLine($"[1] {num}"); // [1] 10

        Do(ref num); // 참조 전달 방식 

        Console.WriteLine($"[3] {num}"); // [3] 20
    }

    static void Do(ref int num)
    {
        num = 20; // [A] 호출한 부분에 적용(Main 메서드의 num 변수의 값이 변경됨)
        Console.WriteLine($"[2] {num}"); // [2] 20
    }
}
