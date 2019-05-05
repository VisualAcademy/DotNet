using System;

namespace VirtualMethod
{
    class Animal
    {
        public virtual void Eat() => Console.WriteLine("Animal Eat");
    }

    class Cat : Animal
    {
        public override void Eat() => Console.WriteLine("Cat Eat");
    }

    class VirtualMethod
    {
        static void Main()
        {
            Animal animal = new Animal();
            animal.Eat();
            Cat cat = new Cat();
            cat.Eat();
        }
    } 
}
