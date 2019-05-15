using System;

class 특성
{
    /// <summary>
    /// 닷넷 1.0 버전
    /// </summary>
    [
        Obsolete(
            "현재 메서드는 오래된 버전이므로, Say2()를 사용하세요.", false)
    ]
    public static void Say1()
    {
        Console.WriteLine("안녕");
    }
    /// <summary>
    /// 닷넷 2.0 버전 이상
    /// </summary>
    public static void Say2()
    {
        Console.WriteLine("안녕하세요");
    }
    static void Main(string[] args)
    {
        //Say1(); // 이 메서드 호출시 경고 또는 에러 발생
        Say2();
    }
}
