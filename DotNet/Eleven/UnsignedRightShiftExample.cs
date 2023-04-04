using System;

class UnsignedRightShiftExample
{
    static void Main()
    {
        int x = -4;
        Console.WriteLine($"이전:       {x,11}, 2진수: {
            Convert.ToString(x, toBase: 2).PadLeft(32, '0'),32}");

        int y = x >> 1;
        Console.WriteLine($">> 이후:    {y,11}, 2진수: {
            Convert.ToString(y, toBase: 2).PadLeft(32, '0'),32}");

        int z = x >>> 1;
        Console.WriteLine($">>> 이후:   {z,11}, 2진수: {
            Convert.ToString(z, toBase: 2).PadLeft(32, '0'),32}");
    }
}
