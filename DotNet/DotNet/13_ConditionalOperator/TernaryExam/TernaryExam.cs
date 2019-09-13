// 입력된 수가 0 이상이면 1을 출력하고 0 미만이면 -1을 출력하는 프로그램
using System;

class TernaryExam
{
    static void Main()
    {
        int number = Convert.ToInt32(Console.ReadLine());

        int result = (number >= 0) ? 1 : -1; 

        Console.WriteLine(result);
    }
}
