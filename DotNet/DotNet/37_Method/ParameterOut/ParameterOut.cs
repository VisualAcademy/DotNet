using System;

class ParameterOut
{
    static void Main()
    {
        int num; // [A] 변수를 반드시 초기화할 필요없음

        Do(out num); // 반환형 매개 변수 전달 방식 

        Console.WriteLine($"[2] {num}"); // [2] 1234
    }

    static void Do(out int num)
    {
        num = 1234; // [B] ref와 동일: 호출한 부분에 적용, 반드시 초기화해야 함
        Console.WriteLine($"[1] {num}"); // [1] 1234
    }
}
