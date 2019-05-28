using System;
using System.Collections.Generic;

/// <summary>
/// 모델 클래스
/// </summary>
public class SignBase
{
    public int SignId { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}

/// <summary>
/// 리포지토리 클래스
/// </summary>
public class SignRepository
{
    public List<SignBase> GetAll()
    {
        var signs = new List<SignBase>()
        {
            new SignBase() { SignId = 1, Email = "a@a.com", Password = "1234" },
            new SignBase() { SignId = 2, Email = "b@b.com", Password = "2345" },
            new SignBase() { SignId = 3, Email = "c@c.com", Password = "3456" },
        };

        return signs; 
    }
}

/// <summary>
/// 컨텍스트 클래스 
/// </summary>
public class SignContext
{
    public List<SignBase> Signs
    {
        get
        {
            return (new SignRepository()).GetAll(); 
        }
    }
}

/// <summary>
/// 테스트 클래스
/// </summary>
class SignBaseSignRepository
{
    static void Main()
    {
        var signs = (new SignContext()).Signs;

        foreach (var sign in signs)
        {
            Console.WriteLine($"{sign.SignId}, {sign.Email}, {sign.Password}");
        }
    }
}
