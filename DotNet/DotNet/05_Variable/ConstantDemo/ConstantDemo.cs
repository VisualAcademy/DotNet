//[?] 상수(Constant): 변하지 않는 변수, 읽기 전용 변수
using System;

class ConstantDemo
{
    static void Main()
    {
        const int MAX = 100; // 정수 형식의 상수 선언과 동시에 초기화 

        Console.WriteLine("최댓값: {0}", MAX);
    }
}
