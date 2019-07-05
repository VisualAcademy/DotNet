//[!] 상수(Constant): 변하지 않는 변수, 읽기 전용 변수
using System;

class ConstDoubleString
{
    static void Main()
    {
        //[1] 상수 선언과 동시에 초기화
        const double PI = 3.14;
        const string SITE_NAME = "닷넷코리아";

        //[2] 상수 참조
        Console.WriteLine(PI); // 3.14
        Console.WriteLine(SITE_NAME); // 닷넷코리아
    }
}
