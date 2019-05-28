// 명령줄인수_짝수의합.exe 1 100 : 1부터 100까지 짝수의 합
// 명령줄인수_짝수의합.exe 10 20 : 10부터 20까지 짝수의 합
using System;

class 명령줄인수_짝수의합
{
    static void Main(string[] args)
    {
        //[1] Initilize
        int sum; int firstNum; int secondNum;
        //[2] Input
        sum = 0;
        firstNum = Convert.ToInt32(args[0]);
        secondNum = Convert.ToInt32(args[1]);
        //[3] Process
        for (int i = firstNum; i <= secondNum; i++)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
        }
        //[4] Output
        Console.WriteLine("{0}부터 {1}까지 짝수의 합 : {2}"
          , firstNum, secondNum, sum);
    }
}
// 명령줄 인수(Command Line Arguments)
// string[] args -> args 배열에
// 프로젝트명.exe 뒤로 나오는 명령줄 인수를 스페이스를 기준으로 받는다.
// 
// ping.exe 127.0.0.1 -t
// args[0] = 127.0.0.1
// args[1] = -t
// 
// C:\>net.exe user red 1234 /add
// args[0] = "user";
// args[1] = red;
// args[2] = 1234;
// args[3] = /add;
