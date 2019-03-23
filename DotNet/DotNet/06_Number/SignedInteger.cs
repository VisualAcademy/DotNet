// 부호(+, -) 있는 정수 데이터 형식: sbyte, short, int, long
using System;

class SignedInteger
{
    static void Main()
    {
        sbyte iSByte = 127;                 //  8비트 부호 있는 정수형 변수 선언 및 할당
        short iInt16 = 32767;               // 16비트 부호 있는 정수형 변수 선언 및 할당
        int   iInt32 = 2147483647;          // 32비트 부호 있는 정수형 변수 선언 및 할당
        long  iInt64 = 9223372036854775807; // 64비트 부호 있는 정수형 변수 선언 및 할당

        Console.WriteLine("sbyte: {0}", iSByte);
        Console.WriteLine("short: {0}", iInt16);
        Console.WriteLine("int  : {0}", iInt32);
        Console.WriteLine("long : {0}", iInt64);
    }
}
