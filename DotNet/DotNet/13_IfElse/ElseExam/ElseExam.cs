using System;

class ElseExam
{
    static void Main()
    {
        // 콘솔로부터 문자 하나 입력받기
        char c = Convert.ToChar(Console.ReadLine());

        if (c == 'a')
        {
            Console.WriteLine("a입니다."); // 입력한 문자가 'a'이면
        }
        else
        {
            Console.WriteLine("a가 아닙니다.");
        }
    }
}
