using System;

namespace VirtualMethod
{
    //[1] 부모 클래스
    class Animal 
    {
        //[?] virtual이 표시된 메서드: 가상 메서드
        public virtual void Eat() => Console.WriteLine("Animal Eat");
    }

    //[2] 자식 클래스
    class Cat : Animal
    {
        public override void Eat() => Console.WriteLine("Cat Eat");
    }

    class VirtualMethod
    {
        static void Main()
        {
            //[A] 부모 인스턴스 생성
            Animal animal = new Animal();
            animal.Eat();
            //[B] 자식 인스턴스 생성
            Animal cat = new Cat(); //[!] 부모 개체에 자식 인스턴스 담기
            cat.Eat();
        }
    } 
}
