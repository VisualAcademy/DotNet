using System;

namespace DotNetInheritance
{
    class SuperClass
    {
        int num;
        public SuperClass(int num) { this.num = num; }
        public void Display() { Console.WriteLine($"num={num}"); }
    }

    class SubClass : SuperClass
    {
        public SubClass(int num) : base(num)
        {
            base.Display();
        }
    }

    class ClassInheritanceDemo
    {
        static void Main()
        {
            SubClass obj = new SubClass(10);
        }
    }
}
