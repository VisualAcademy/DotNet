//아래 수열의 결과값을 구하는 프로그램을 작성하시오.
// 1 + 2 + 4 + 7 + 11 + 16 + 22 + ... + 
// 위 패턴대로 20번 반복했을 때의 결과값은? 얼마? 
using System;

public class 수열퀴즈
{
    public static void Main()
    {
        //[1] 입력
        int data = 1;
        int sum = 0; 
        //[2] 처리
        for (int i = 0; i < 20; i++) // 20번 반복
        {
            Console.Write("{0} + ", data);
            sum += data; // 1누적
            data = data + (i + 1); // 다음 번 인덱스를 더하자.
        }
        //[3] 출력
        Console.WriteLine("\n{0}", sum); // 1350
    }    
}