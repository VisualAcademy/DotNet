using System;

class SingleMultiple
{
    static void Main()
    {
        //[1] 단문: 3가지 스타일
        if (1 == 1) Console.WriteLine("단문 1");
        if (1 == 1)
            Console.WriteLine("단문 2");
        if (1 == 1)
        {
            Console.WriteLine("단문 3");
        }

        //[2] 복문: 반드시 중괄호 사용
        if (1 == 1)
        {
            Console.WriteLine("복문 A");
            Console.WriteLine("복문 B");
        }
    }
}
