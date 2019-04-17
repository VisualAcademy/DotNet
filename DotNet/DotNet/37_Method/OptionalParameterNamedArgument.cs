using System;

namespace OptionalParameterNamedArgument
{
    class OptionalParameterNamedArgument
    {
        static void Main(string[] args)
        {
            // Optional Parameter 테스트
            MyMethod();     // 20
            MyMethod(40);   // 40
            MyMethod(80, "반갑습니다");
            
            // Named Argument / Named Parameter
            MyMethod(30, b: "또봐");
            MyMethod(a: 30, b: "Hello");
            MyMethod(b: "Bye", a: 100); // 100, Bye
            MyMethod(b: "a는 기본값이 호출되겠지요");
            
            // Named Argument에는 메서드의 결과값을 사용 가능
            MyMethod(a: GetA(), b: GetB()); // 1000, "Good bye"
            MyMethod(b: GetB(), a: GetA()); // 1000, "Good bye"

            // 생성자 오버로드
            PointClass p1 = new PointClass();
            p1.Print(); // 2개 모두 기본값이 호출
            var p2 = new PointClass(10);
            p2.Print(); // X : 10
            var p3 = new PointClass(200, 100);
            p3.Print();
            var p4 = new PointClass(Y: 300); // Named Argument
            p4.Print();

            // 제네릭 메서드와 오버로드시 문제점 해결
            GenericMethod(1234);                // 제
            GenericMethod(1234.56);             // 제
            GenericMethod(x: 34);               // 일
            GenericMethod(100, 200);            // 일
            GenericMethod(x: 100, y: 200);      // 일
        }

        #region Optional Parameter Test
        private static string GetB()
        {
            Console.WriteLine("B 메서드 호출");
            return "Good bye";
        }

        private static int GetA()
        {
            Console.WriteLine("A 메서드 호출");
            return 1000;
        }

        // Optional Parameter를 사용하여 메서드 구현
        private static void MyMethod(int a = 20, string b = "안녕")
        {
            Console.WriteLine("a : {0}, b : {1}", a, b);
        } 
        #endregion

        #region Generic Method Test
        //private static void GenericMethod(int x)
        //{
        //    Console.WriteLine("일 반 x : {0}", x);
        //}
        static void GenericMethod(int x, int y = 2345)
        {
            Console.WriteLine("일 반 x : {0}, y : {1}", x, y);
        }

        //static void GenericMethod<T>(T x)
        //{
        //    Console.WriteLine("제네릭 x : {0}", x);
        //}
        static void GenericMethod<T>(T g)
        {
            Console.WriteLine("제네릭 x : {0}", g);
        }
        #endregion
    }

    public class PointClass
    {
        public int X { get; set; }
        public int Y { get; set; }

        // 3개의 생성자가 오버로드
        public PointClass(int X = 100, int Y = 200) // Optional Parameter
        {
            this.X = X;
            this.Y = Y;
        }

        public void Print()
        {
            Console.WriteLine("X : {0}, Y : {1}", X, Y);
        }
    }
}
