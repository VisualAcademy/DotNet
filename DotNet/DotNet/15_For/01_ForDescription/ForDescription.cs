//[?] for 문을 사용하여 "안녕하세요." 3번 출력하기
using System;

class ForDescription
{
    static void Main()
    {
        //[!] for (초기식; 조건식; 증감식) { 실행문; }
        for (int i = 0; i < 3; i++) // i가 0, 1, 2일 때 
        {
            Console.WriteLine("안녕하세요."); // 안녕하세요. 출력
        }
    }
}
