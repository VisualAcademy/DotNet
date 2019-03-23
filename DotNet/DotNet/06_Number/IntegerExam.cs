using System;

class IntegerExam
{
    static void Main()
    {
        SByte i08; // sbyte
        Int16 i16; // short
        Int32 i32; // int
        Int64 i64; // long

        i08 = SByte.MinValue;
        i16 = Int16.MinValue;
        i32 = Int32.MinValue;
        i64 = Int64.MinValue;

        Console.WriteLine("{0}, {1}, {2}, {3}", i08, i16, i32, i64);
    }
}
