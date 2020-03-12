using System;

class TupleLiteralDescription
{
    static void Main() =>  Tally();

    static void Tally()
    {
        //[?] 튜플 리터럴(Tuple Literal)
        var r = (12, 34, 56); // 3개의 int 형식 데이터가 r 변수에 담김
        Console.WriteLine($"{r.Item1}, {r.Item2}, {r.Item3}");
    }
}
