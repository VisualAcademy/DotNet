using System;

class WhileLoop
{
    static void Main()
    {
        int count = 1;                                  // 초기식
        while (count <= 3)                              // 조건식
        {
            Console.WriteLine($"카운트: {count}");       // 실행문
            count++;                                    // 증감식
        }
    }
}
