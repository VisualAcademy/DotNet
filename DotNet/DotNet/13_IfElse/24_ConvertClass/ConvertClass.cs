using System;
using static System.Console;
using static System.Convert;

class ConvertClass
{
    static void Main()
    {
        //[1] Convert.ToXXX()
        WriteLine(ToInt32(3.14)); // 3
        WriteLine(ToDouble("3.14")); // 3.14
        WriteLine(Convert.ToString(3.14)); // 3.14 => "3.14"
        WriteLine(Convert.ToString(3.14).GetType()); // "String"
        WriteLine(3.14.ToString()); // 3.14 => "3.14"

        //[2] XXX.TryParse(,)
        if (double.TryParse("3.14", out var r))
        {
            WriteLine($"{r}: {r.GetType()}"); // 3.14: System.Double
        }
        else
        {
            WriteLine("변환 불가");
        }
        Console.WriteLine(r); // if 문에서 생성된 r 값을 사용 가능
    }
}
