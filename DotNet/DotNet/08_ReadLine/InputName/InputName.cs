using System;

class InputName
{
    static void Main()
    {
        //[1] 콘솔에 "이름을 입력하시오 =>" 출력 
        Console.Write("이름을 입력하시오 => ");
        //[2] 콘솔로부터 문자열을 입력받아 name 변수에 저장
        string name = Console.ReadLine();
        //[3] name 변수의 값을 {0}에 출력
        Console.WriteLine("안녕하세요. {0}님.", name); 
    }
}
