//[!] 상수(Constant): 변하지 않는 변수, 읽기 전용 변수
class 상수
{
    static void Main(string[] args)
    {
        //[1] 상수 선언과 동시에 초기화
        const double PI = 3.14;
        const string SITE_NAME = "닷넷코리아";

        //[2] 상수 참조
        System.Console.WriteLine(PI); // 3.14
        System.Console.WriteLine(SITE_NAME); // 닷넷코리아
    }
}
