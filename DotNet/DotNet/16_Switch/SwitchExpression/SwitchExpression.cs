// switch 문: 선택문
using System;

class SwitchExpression
{
    static void Main()
    {
        int x = 2;

        switch (x)
        {
            case 1:
                Console.WriteLine("1입니다."); // x가 1일 때 실행
                break;
            case 2:
                Console.WriteLine("2입니다."); // x가 2일 때 실행
                break;
        }
    }
}
