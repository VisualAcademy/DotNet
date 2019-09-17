using Korea.Seoul; // Korea.Seoul 네임스페이스의 클래스를 바로 사용 가능
using System;
using In = Korea.Incheon; // Korea.Incheon 네임스페이스를 In 네임스페이스로 별칭 붙여 사용

namespace Korea
{
    namespace Seoul
    {
        public class Car
        {
            public void Run() => Console.WriteLine("서울 자동차가 달립니다.");
        }
    }

    namespace Incheon
    {
        public class Car
        {
            public void Run() => Console.WriteLine("인천 자동차가 달립니다.");
        }
    }
}

namespace NamespaceDescription
{
    class NamespaceDescription
    {
        static void Main()
        {
            //[1] 네임스페이스 전체 지정
            Korea.Seoul.Car s = new Korea.Seoul.Car();
            s.Run(); // 서울
            Korea.Incheon.Car i = new Korea.Incheon.Car();
            i.Run(); // 인천

            //[2] 네임스페이스 선언부에 선언
            Korea.Incheon.Car seoul = new Korea.Incheon.Car();
            seoul.Run(); // 서울

            //[3] 별칭을 사용해서 간결하게 사용
            In.Car ic = new In.Car();
            ic.Run(); // 인천
        }
    }
}
