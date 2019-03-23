using System;

namespace 제어문_구간반복
{
    class 제어문_구간반복
    {
        static void Main(string[] args)
        {
            // for (초기식;조건식;증감식) { 실행문; }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("안녕하세요.");
            }

            for (
              int i = 0;            //초기식
              i < 5;                //조건식
              i++                   //증감식
            )
            {
                Console.WriteLine(i); //실행문  
            }

            for (int i = 1; i <= 5; i++)
            {

            }

            for (int i = 0; i < 1000; i++)
            {

            }

            // 1, 2, 3
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("{0}", i);
            }

            //

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hi");
            }

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("{0}\t", i);
            }
            Console.WriteLine();
        }
    }
}
