// 부호 없는 정수 데이터 형식: byte, ushort, uint, ulong
using System;

class UnsignedInteger
{
    static void Main()
    {
        byte iByte   = 255;                  //  8비트 부호 없는 정수형 변수 선언 및 할당
        ushort iUInt16 = 65535;                // 16비트 부호 없는 정수형 변수 선언 및 할당
        uint iUInt32 = 4294967295;           // 32비트 부호 없는 정수형 변수 선언 및 할당
        ulong iUInt64 = 18446744073709551615; // 64비트 부호 없는 정수형 변수 선언 및 할당

        Console.WriteLine("byte  : {0}", iByte  );
        Console.WriteLine("ushort: {0}", iUInt16);
        Console.WriteLine("uint  : {0}", iUInt32);
        Console.WriteLine("ulong : {0}", iUInt64);
    }
}
