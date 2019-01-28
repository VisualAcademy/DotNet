using System;

class 이름입력받기
{
    static void Main(string[] args)
    {
        Console.Write("이름을 입력하시오 => "); // 콘솔에 "이름을 입력하시오 =>" 출력 
        string name = Console.ReadLine(); // 콘솔로부터 문자열을 입력받아 name 변수에 저장
        Console.WriteLine("안녕하세요. {0}님.", name); // name 변수의 값을 {0}에 출력
    }
}
