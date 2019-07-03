using System;

class IfExam
{
    static void Main()
    {
        //int age = 13;
        //if (age < 14)
        //{
        //    Console.WriteLine("만 14세 미만 어린이는 부모님의 동의가 필요합니다.");
        //}
        int age = Convert.ToInt32(Console.ReadLine());
        if (age < 14)
        {
            Console.WriteLine("만 14세 미만 어린이는 부모님의 동의가 필요합니다.");
        }
    }
}
