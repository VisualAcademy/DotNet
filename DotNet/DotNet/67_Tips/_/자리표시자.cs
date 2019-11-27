using System;

public class 자리표시자 // 자리 채움자(Place Holder)
{
    public static void Main()
    {
        Console.WriteLine("자리" + "표시자");
        Console.WriteLine(
            "{0} {1} {2}", "안녕", "방가", "또봐");
        Console.WriteLine("{0} {1} {0}", "안녕", "또봐");
        Console.WriteLine("{0}", 1234);
        Console.WriteLine("{0,10}", 1234);//자리 10칸잡고 출력
        Console.WriteLine("[{0,-10:C}]", 1234);//왼쪽 원표시

        //http://msdn2.microsoft.com/en-us/library/dwhawy9k(VS.71).aspx 
    }
}
