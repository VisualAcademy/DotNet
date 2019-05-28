using System;

class Constant
{
    static void Main()
    {
        // 변수(Variable) 
        int num = 1234;

        // 상수(Constant)
        const int j = 20; // j는 20으로 고정
        // j = 30; // j를 30으로 변경하려고하면 에러가 발생
        Console.WriteLine(j); // 20

        // 상수는 대문자 형태로 표현함
        const double PI = 3.14;
        const string SITE_NAME = "닷넷코리아";

        // 변경
        num = 2345;
        // PI = 5.15; // PI의 값을 변경하려고하면 에러발생

        // 참조
        Console.WriteLine("{0}", num);
        Console.WriteLine("{0}", PI);
        Console.WriteLine("{0}", SITE_NAME);
    }
}
