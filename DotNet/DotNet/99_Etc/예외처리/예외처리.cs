using System;

class 예외처리복습
{
    static void Main(string[] args)
    {
        // 예외 처리 : 에러 처리

        //[1] Input
        int a = 3;
        int b = 0; // int b = 5;
        double r = 0.0;

        //[2] Process

        ////[a] 완벽한 하나의 프로그램
        //r = a + b;

        ////[b] 0으로 나눌 수 없다.
        //r = a / b; // 런타임 에러 발생 : 0으로 나누려고하기에... => 강제 종료

        //[c] 예외 처리: 강제 종료 대신 에러를 처리하는 코드 삽입해서 정상 종료
        // try~catch~finally절
        try // 예외가 발생할 만한 코드를 작성
        {
            r = a / b;

            //[3] Output
            Console.WriteLine("r : {0}", r);
        }
        catch (Exception e) // 예외가 발생할 때 처리해야 할 코드 블록
        {
            Console.WriteLine("예외(에러)가 발생됨: {0}", e.Message);
        }
        finally // 예외가 발생하거나 정상일 때 모두 처리해야 할 코드 블록
        {
            Console.WriteLine("프로그램을 종료합니다.");
        }

        // throw 키워드: 강제로 특정 에러를 발생
        try
        {
            a = 4;
            if (a % 2 == 0)
            {
                // 무조건 에러 발생 => 비정상 종료
                throw (new Exception("내가 만든 에러"));
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("예외(에러)가 발생됨: {0}", e.Message);
        }
        finally
        {
            Console.WriteLine("프로그램을 정상 종료합니다.");
        }

    }
}
