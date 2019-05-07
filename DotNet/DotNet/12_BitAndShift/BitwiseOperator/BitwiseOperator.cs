// 비트 연산자: &, |, ~, ^
// X1010
// Y0110
// &0010
// |1110
// ^1100
// ~0101
using System;

class BitwiseOperator
{
    static void Main()
    {
        int x = Convert.ToInt32("1010", 2); // 10
        int y = Convert.ToInt32("0110", 2); // 6

        int and = x & y;
        Console.WriteLine($"{and} : {Convert.ToString(and, 2)}"); // 2, 0010

        int or = x | y;
        Console.WriteLine($"{or} : {Convert.ToString(or, 2)}"); // 14, 1110

        int xor = x ^ y;
        Console.WriteLine($"{xor} : {Convert.ToString(xor, 2)}"); // 12, 1100

        int not = ~x; // 2의 보수법에 의해서 1010 + 1 그리고 부호를 -로 -1011 => -11
        Console.WriteLine($"{not} : {Convert.ToString(not, 2)}"); // -11, ~~~~0101
    }
}
