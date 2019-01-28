//[?] 문자열 묶는 3가지 표현 방법 정리
using System;

class StringDisplay
{
    static void Main()
    {
        var displayName = "";
        var firstName = "길동";
        var lastName = "홍";

        //[1] 더하기(+) 연산자 사용
        displayName = "이름: " + lastName + firstName;
        Console.WriteLine(displayName); // 이름: 홍길동

        //[2] string.Format(), String.Format() 메서드 사용
        displayName = string.Format("이름: {0}{1}", lastName, firstName);
        Console.WriteLine(displayName); // 이름: 홍길동

        //[3] 문자열 보간법 사용
        displayName = $"이름: {lastName}{firstName}";
        Console.WriteLine(displayName); // 이름: 홍길동 
    }
}
