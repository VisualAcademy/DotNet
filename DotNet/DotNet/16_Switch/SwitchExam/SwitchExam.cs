using System;

class SwitchExam
{
    static void Main()
    {
        Console.WriteLine("100 또는 500을 입력하세요.");
        int coin = Convert.ToInt32(Console.ReadLine());

        switch (coin)
        {
            case 100:
                Console.WriteLine("백원");
                break;
            case 500:
                Console.WriteLine("오백원");
                break;
            default:
                Console.WriteLine("잘못 입력");
                break;
        }
    }
}
