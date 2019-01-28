using System;

namespace StructNote
{
    //[1] 구조체 선언
    struct BusinessCard
    {
        public string Name; // Name 필드(Field): 필드 개념은 따로 클래스 시간에 배움
        public int Age;
        public string Address;
    }
    
    class StructNote
    {
        static void Main()
        {
            //[A] int 형식, string 형식 변수가 아닌 구조체 형식 변수 선언
            BusinessCard my;

            //[B] 구조체의 Name, Age, Address 변수(필드)에 접근해서 사용 
            my.Name = "홍길동";
            my.Age = 21;
            my.Address = "서울시";

            //[C] 구조체를 사용하면 서로 다른 형식의 변수를 묶어서 관리하는 편리함 제공 
            Console.WriteLine($"{my.Name}, {my.Age}, {my.Address}");
        }
    }
}
