using System;

class ConsoleReadDemo
{
    static void Main()
    {
        //[1] 콘솔로부터 문자 하나를 입력 후 엔터키를 누릅니다. 
        int x = Console.Read();

        //[2] 대문자 'A'가 입력되면 'A'에 해당하는 정수 값인 65가 출력됩니다.
        Console.WriteLine(x);

        //[3] x가 65면 정수 65에 해당하는 유니코드 문자인 A가 출력됩니다. 
        Console.WriteLine(Convert.ToChar(x)); 
    }
}
