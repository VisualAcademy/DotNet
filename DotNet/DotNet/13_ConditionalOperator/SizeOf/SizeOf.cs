//[?] sizeof 연산자로 데이터 형식의 크기 구하기
using System;

class SizeOf
{
    static void Main()
    {
        Console.WriteLine("sizeof(데이터 형식)");
        Console.WriteLine($"  char 형식: {sizeof(  char)} byte");      
        Console.WriteLine($"   int 형식: {sizeof(   int)} byte");       
        Console.WriteLine($"  long 형식: {sizeof(  long)} byte");      
        Console.WriteLine($" float 형식: {sizeof( float)} byte");     
        Console.WriteLine($"double 형식: {sizeof(double)} byte");    
    }
}
