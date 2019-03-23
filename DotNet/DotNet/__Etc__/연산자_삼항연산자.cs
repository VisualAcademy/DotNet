// 조건연산자(3항연산자) => ? : 
// (조건식) ? 참일때수행문장 : 거짓일때수행문장;
using System;

namespace 연산자_삼항연산자
{
    class 연산자_삼항연산자
    {
        static void Main(string[] args)
        {
            int num = 9;
            string result = "";

            // 3항 연산자(if문과 동일)
            result = (num % 2 == 0) ? "짝수" : "홀수";

            Console.WriteLine(result);
        }
    }
}
