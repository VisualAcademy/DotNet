//[?] while 문: 조건식이 참일 동안 반복 실행
using System;

class WhileDemo
{
    static void Main()
    {
        int i = 1;
        while (i <= 5)
        {
            Console.WriteLine("카운트: {0}", i);
            i++; 
        }
    }
}
