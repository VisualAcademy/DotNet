using System;

class Say
{
    //[1] 필드(멤버 변수)
    private string message = "안녕하세요."; // 필드 이니셜라이저

    //[2] 메서드
    public void Hi()
    {
        this.message = "반갑습니다.";
        Console.WriteLine(this.message);
    }
}

class FieldInitializer
{
    static void Main()
    {
        Say say = new Say();
        say.Hi();
    }
}
