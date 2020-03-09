using System;

class UserService
{
    // 자동 속성: 속성 선언과 동시에 초기화 가능
    public static int UserId { get; set; } = 1234;
}

class AutoProperty
{
    static void Main()
    {
        Console.WriteLine(UserService.UserId); // 1234
    }
}
