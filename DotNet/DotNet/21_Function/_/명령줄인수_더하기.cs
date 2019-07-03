using System;

class 명령줄인수_더하기
{
    // 명령줄인수_더하기.exe 10 20 => 30
    static void Main(string[] args)
    {
        int first = 0;
        int second = 0;
        int result = 0;

        if (args.Length >= 2)
        {
            first = Convert.ToInt32(args[0]);
            second = Convert.ToInt32(args[1]);
            result = first + second;

            Console.WriteLine("{0} + {1} = {2}", first, second, result);
        }
        else
        {
            Console.WriteLine("명령줄 인수 값이 입력되어야 합니다.");
        }
    }
}
