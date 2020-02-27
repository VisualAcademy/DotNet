//[?] 구구단을 1단부터 9단까지 출력하는 프로그램
using System;

class 알고리즘_구구단_기본출력
{
    static void Main()
    {
        var arr = new int[10]; 
        var dan = 0;  // 단(1~9)
        do
        {
            var su = 0;
            dan = dan + 1;
            Console.WriteLine($"{dan} 단");
            do
            {
                su = su + 1;
                arr[su] = dan * su; 
            } while (su < 9);
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"{dan} * {i} = {arr[i]}");
            }
            Console.WriteLine();
        } while (dan < 9);
    }
}
