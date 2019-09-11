using System;
using static System.Console;

class 데이터형식_실수
{
    static void Main()
    {
        // float: 32비트
        WriteLine("float:   \t{0}~{1}", Single.MinValue, Single.MaxValue);
        // double: 64비트
        WriteLine("double:  \t{0}~{1}", Double.MinValue, Double.MaxValue);
        // decimal: 128비트
        decimal max = Decimal.MaxValue;
        decimal min = Decimal.MinValue;
        WriteLine("decimal: \t{0}~{1}", min, max);
    }
}
