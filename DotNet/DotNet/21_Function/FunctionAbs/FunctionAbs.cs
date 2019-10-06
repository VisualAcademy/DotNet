using System;

class FunctionAbs
{
    //[?] 절댓값을 구하는 함수 만들기
    static int Abs(int num)
    {
        return (num < 0) ? -num : num;
    }

    static void Main()
    {
        int num = -21;
        int abs = Abs(num);
        Console.WriteLine($"{num}의 절댓값: {abs}");
    }
}
