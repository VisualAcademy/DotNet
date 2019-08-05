namespace 네임스페이스
{
    using Korea.Hyundai; // *
    using System;
    using Star = Korea.Samsung; // 별칭

    namespace Korea
    {
        namespace Hyundai
        {
            public class Car
            {
                public void Run()
                {
                    Console.WriteLine("현대 자동차가 달립니다.");
                }
            }
        }

        namespace Samsung
        {
            public class Car
            {
                public void Run()
                {
                    Console.WriteLine("삼성 자동차가 달립니다.");
                }
            }
        }
    }


    namespace 네임스페이스
    {
        class 네임스페이스
        {
            static void Main(string[] args)
            {
                //[1] 네임스페이스 전체 지정
                Korea.Hyundai.Car h = new Korea.Hyundai.Car();
                h.Run();
                Korea.Samsung.Car s = new Korea.Samsung.Car();
                s.Run();

                //[2] 네임스페이스 선언부에 선언
                Car hc = new Car();
                hc.Run(); // 현대

                //[3] 별칭을 사용해서 간결하게
                Star.Car sc = new Star.Car();
                sc.Run(); // 삼성
            }
        }
    }
}
