using System;

class 선택문
{
    static void Main()
    {
        // 현재 날짜/시간 출력
        Console.WriteLine($"현재 시간 전체: {DateTime.Now}");
        // 현재 시간
        Console.WriteLine($"현재 시간: {DateTime.Now.Hour}시");

        // 24시간마다 서로 다른 메시지/기능 구현
        switch (DateTime.Now.Hour)
        {
            case 0:
                Console.WriteLine("자정");
                break;
            case 10:
                Console.WriteLine("10시");
                break;
            case 11:
                Console.WriteLine("11시");
                break;
            default:
                Console.WriteLine("기타 다른 시간대");
                break;
        }

        //if (DateTime.Now.Hour == 9)
        //{
        //    Console.WriteLine("9시");
        //}
        //else if (DateTime.Now.Hour == 10)
        //{
        //    Console.WriteLine("10시");
        //}
    }
}
