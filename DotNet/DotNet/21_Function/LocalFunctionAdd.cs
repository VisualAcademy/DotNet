using System;

class LocalFunctionAdd
{
    static void Main()
    {
        // 로컬 함수 만들기
        int Add(int a, int b) => a + b;
        decimal Subtract(decimal x, decimal y) => x - y;

        // 로컬 함수 사용하기 
        Console.WriteLine($"3 + 5 = {Add(3, 5)}");
        Console.WriteLine($"34.56 - 12.34 = {Subtract(34.56M, 12.34M)}");
    }
}
