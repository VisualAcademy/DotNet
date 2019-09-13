// 변수(Variable) : 하나의 이름으로 하나의 데이터형식을 하나만 보관해 놓는 그릇 역할
using System;

public class 데이터형식과변수
{
    public static void Main()
    {
        //[1] 변수 선언
        int num;    // 정수형 변수
        double su;  // 실수형 변수 
        bool flag;  // 부울형 변수 
        string str; // 문자열 변수
        char c;     // 문자형 변수
        object obj; // 객체형(임의값) 변수: 모든 값

        //[2] 변수 초기화(할당)
        num = 1234;
        su = 3.141592;
        flag = true; // true, false
        str = "안녕하세요.";
        c = '가'; // 2bytes 코드
        obj = DateTime.Now; // 날짜형

        //[3] 변수 참조(사용)
        Console.WriteLine("num : {0}", num);
        Console.WriteLine("su : {0}", su);
        Console.WriteLine("{0}, {1}", flag, false);
        Console.WriteLine("{0}", str);
        Console.WriteLine("{0}, {1}, {2}", c, '\t', 'A');
        Console.WriteLine("{0}", obj);
    }
}
