using System;

class Constant
{
    static void Main()
    {
        // 변수(Variable) 
        string name = "박용준";
        name = "레드플러스"; // 변경 가능

        // 상수(Constant)
        const int age = 20; // j는 20으로 고정
        // age = 45; // age를 45로 변경하려고하면 에러가 발생

        // 변수와 상수 사용
        Console.WriteLine($"{name} - {age}");

        // 상수는 일반적으로 대문자 형태로 표현함
        const double PI = 3.14;
        const string SITE_NAME = "닷넷코리아";

        Console.WriteLine("{0}", PI);
        Console.WriteLine("{0}", SITE_NAME);
    }
}
