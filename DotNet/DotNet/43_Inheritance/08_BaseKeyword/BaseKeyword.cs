using System;

namespace BaseKeyword
{
    public class Car
    {
        private string name; 
        public Car(string name)
        {
            this.name = name;
        }
        public void Run() => Console.WriteLine($"{this.name}가 달린다.");
    }
    public class My : Car
    {
        public My() : this("나의 자동차") { }
        public My(string name) : base(name) { }
    }
    public class Your : Car
    {
        public Your() : base("너의 자동차") { }
    }

    class BaseKeyword
    {
        static void Main()
        {
            (new My()).Run();
            (new My("나의 끝내주는 자동차")).Run();
            new Your().Run();
        }
    }
}
