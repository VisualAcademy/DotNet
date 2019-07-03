using System;

class DoWhile
{
    static void Main()
    {
        int count = 0;                          // 초기식
        do
        {
            Console.WriteLine("안녕하세요.");    // 실행문
            count++;                            // 증감식
        } while (count < 3);                    // 조건식
    }
}
