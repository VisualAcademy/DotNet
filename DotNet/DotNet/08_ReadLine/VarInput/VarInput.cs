using System;

class VarInput
{
    static void Main()
    {
        // 문자열 입력 받기
        var s = Console.ReadLine();

        // 문자 하나 입력 받기
        var c = Convert.ToChar(Console.Read());

        // 입력받은 값과 형식 출력하기 
        Console.WriteLine($"{s}: {s.GetType()}, {c}: {c.GetType()}"); 
    }
}
