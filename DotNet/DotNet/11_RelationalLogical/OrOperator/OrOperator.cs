using System;

class OrOperator
{
    static void Main()
    {
        // 하나라도 참이면 참
        Console.WriteLine(false || true); // True
        // 둘 다 거짓일때에만 거짓
        Console.WriteLine(false || false); // False
    }
}
