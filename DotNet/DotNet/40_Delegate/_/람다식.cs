using System;

namespace 람다식 // 무명 메서드의 확장형
{
    class 람다식
    {
        // 대리자
        delegate int Sum(int i);

        // 반환값과 매개변수 타입 지정
        // 제네릭 대리자 : A 타입의 인수를 받아서, R 타입의 결과를 반환
        delegate R Func<A, R>(A arg);

        static void Main(string[] args)
        {
            // 람다 식 : => 
            Sum sum = (x => x + 10);
            Console.WriteLine(sum(5)); // x = 5 + 10; 15값 반환
      
            // 람다 식
            Func<int, int> f1 = (x => x + 10);
            Console.WriteLine(f1(3)); // x = 3 + 10; 13값 반환
            Func<int, double> f2 = (x => x + 10);
            Console.WriteLine(f2(3)); // x = 3 + 10; 13값 반환
            //Func<double, int> f3 = (x => x + 10);
            //Console.WriteLine(f3(3)); // double을 int로 반환 불가 : 에러
        }
    }
}
