using System;

class PercentOperator
{
    static void Main()
    {
        int f = 10;
        int s = 5;
        int r = f % s; // r 변수에는 (f / s) 결과의 나머지 값이 저장
        Console.WriteLine("{0} % {1} = {2}", f, s, r);
    }
}
