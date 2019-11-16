using static System.Console;

class TupleReturnDescription
{
    //[1] 튜플 리턴(Tuple Return) 형식: (int, int) 
    static (int, int) Tally1()
    {
        var r = (12, 3); //[A] 튜플 리터럴에 2개의 값 담기 
        return r; //[B] 튜플 리터럴 반환
    }

    //[2] 튜플 리턴에 이름 값 지정 가능
    static (int Sum, int Count) Tally2() => (45, 6); 

    static void Main()
    {
        var t1 = Tally1();
        WriteLine($"Sum: {t1.Item1}, Count: {t1.Item2}");
        var t2 = Tally2();
        WriteLine($"Sum: {t2.Sum}, Count: {t2.Count}");
    }
}
