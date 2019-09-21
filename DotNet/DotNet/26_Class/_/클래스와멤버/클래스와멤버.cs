namespace 클래스와멤버
{
    //[1][1] 클래스 생성
    public class 클래스
    {
        //[1][2] 멤버 생성
        public static void 멤버()
        {
            System.Console.WriteLine("클래스의 멤버가 호출되어 실행됩니다.");
        }
    }

    public class 클래스와멤버
    {
        public static void Main()
        {
            //[2][1] 클래스 사용
            클래스.멤버();
        }
    }
}
