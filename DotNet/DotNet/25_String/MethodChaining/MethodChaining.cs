//[?] 메서드 체이닝으로 StringBuilder 클래스의 여러 메서드 호출하기
using System;
using System.Text;

class MethodChaining
{
    static void Main()
    {
        var message = new StringBuilder()
            .AppendFormat("{0} 클래스를 사용한 ", nameof(StringBuilder))
            .Append("메서드 ")
            .Append("체이닝 ")
            .ToString()
            .Trim();
        Console.WriteLine(message);
    }
}
