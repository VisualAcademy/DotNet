// 증감연산자(Increment/Decrement Operator)
// ++ 연산자 : 변수의 값을 1증가
// -- 연산자 : 변수의 값을 1감소
// 전위 : ++/-- 연산자가 변수 앞에 오면 우선 증가/감소
// 후위 : ++/-- 연산자가 변수 뒤에 오면 해당 라인 실행 후 나중 실행
using System;

public class 연산자_증감연산자
{
    public static void Main()
    {
        int a, b, c, r;

        a = 3;
        b = 5;
        c = 7;

        //r = ++a; // 전위 증감 연산자
        //r = a++; // 후위 증감 연산자
        // r = ++a - b--; 
        r = a-- - ++b * c++;

        Console.WriteLine("r : {0}, a : {1}, b : {2}, c : {3}", r, a, b, c); //?
    }
}
