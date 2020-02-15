// FunctionReturnValue.cs
// 반환값이 있는 함수(메서드)
using System;

class FunctionReturnValue
{
    static int SquareFunction(int x)    // 입력: 매개 변수도 있고 
    {
        int r = x * x;                  // 처리: 함수의 본문
        return r;                       // 출력: 반환값도 있는 
    }
    static void Main()
    {
        int r = SquareFunction(2); // 함수 호출 및 반환값 받기 
        Console.WriteLine(r); // 4
    }
}
