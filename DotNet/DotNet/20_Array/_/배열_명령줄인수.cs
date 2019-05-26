using System;

namespace 배열_명령줄인수
{
    class 배열_명령줄인수
    {
        // 배열.exe 1 100 3 <-- 1부터 100까지 3의 배수의 합
        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("배열.exe 시작 끝 배수");
                return;
            }
            int start = Convert.ToInt32(args[0]);//1
            int end = Convert.ToInt32(args[1]);//100
            int num = Convert.ToInt32(args[2]);//3
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                if (i % num == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("{0}~{1}까지 {2}의 배수의 합 : {3}"
                , start, end, num, sum);
        }
    }
}

