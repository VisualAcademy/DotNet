//[?] 액세스 한정자(Access Modifiers): 접근 권한
// - public: 공용(제한 없음)
// - private: 전용(해당 클래스내에서만 접근)
using System;

namespace PublicAndPrivate
{
    public class Car
    {
        // 메서드
        public static void Hi() { Console.WriteLine("Hi"); }
        private static void Bye() { Console.WriteLine("Bye"); }

        // 필드
        public static string name;   // 이름
        private static int age;      // 나이

        // private한 필드를 외부에 공개하고자할 때에는 public한 메서드로 공개
        public static void SetAge(int intAge) { age = intAge; }
        public static int GetAge() { return age; }
    }

    class PublicAndPrivate
    {
        static void Main()
        {
            //[1] public 멤버는 항상 접근 가능
            Car.Hi();

            //[2] private 멤버는 다른 클래스에서 접근 불가
            //Car.Bye();

            //[3] public 필드는 외부에서 접근 가능
            Car.name = "RedPlus"; Console.WriteLine(Car.name);

            //[4] public 메서드로 필드의 값을 설정(Set) 및 조회(Get)
            Car.SetAge(21);
            Console.WriteLine(Car.GetAge());
        }
    }
}
