using System;
using static System.Console;

class TryCatchFinallyDemo4
{
    static void Main()
    {
        int x = 5;
        int y = 0;
        int r;

        try // 예외가 발생할만한 구문이 들어오는 곳
        {
            r = x / y; // 0으로 나누기 시도
            WriteLine($"{x} / {y} = {r}");
        }
        catch (Exception ex)
        {
            WriteLine($"예외 발생: {ex.Message}");
        }
        finally // 예외가 발생하던 안하던 실행
        {
            WriteLine("프로그램을 종료합니다.");
        }
    }
}
