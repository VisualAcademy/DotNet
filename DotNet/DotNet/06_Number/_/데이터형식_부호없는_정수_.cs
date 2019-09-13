using System;
using static System.Console;

class 데이터형식_부호없는_정수_
{
    static void Main(string[] args)
    {
        WriteLine("[08비트] byte:  \t{0}~{1}",   Byte.MinValue,   Byte.MaxValue);
        WriteLine("[16비트] ushort:\t{0}~{1}", UInt16.MinValue, UInt16.MaxValue);
        WriteLine("[32비트] uint:  \t{0}~{1}", UInt32.MinValue, UInt32.MaxValue);
        WriteLine("[64비트] ulong: \t{0}~{1}", UInt64.MinValue, UInt64.MaxValue);
    }
}
//[08비트] byte:          0~255
//[16비트] ushort:        0~65535
//[32비트] uint:          0~4294967295
//[64비트] ulong:         0~18446744073709551615
//계속하려면 아무 키나 누르십시오. . .
