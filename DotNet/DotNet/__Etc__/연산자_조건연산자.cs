// 조건연산자(3항연산자) => ? :
// (조건식) ? 참일때수행문장 : 거짓일때수행문장;
using System;

class 연산자_조건연산자
{
    static void Main()
    {
        int num = 9;
        string result = "";

        // 3항 연산자(if문과 동일)
        result = (num % 2 == 0) ? "짝수" : "홀수";

        Console.WriteLine(result);

        //int i = 10;
        //string j;
        //bool k;
        //k = (
        //  ((i % 2) == 0)
        //  &&
        //  ((i % 2) != 1)
        //);
        //j = (k == true) ? "참" : "거짓";
        //Console.WriteLine(j);

        //if (k == true)
        //{
        //    j = "참";
        //}
        //else
        //{
        //    j = "거짓";
        //}
        //Console.WriteLine(j);        
    }
}
