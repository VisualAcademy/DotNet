using System;

namespace 속성
{
    // 자동차 속성: 이름, 색상, ...
    public class Car
    {
        // 필드
        private string name;
        // 속성(Property)
        public string Name
        {
            get
            {
                return name; // 필드를 외부에 공개
            }
            set
            {
                name = value; // 외부에서 전달된 값을 필드에 초기화
            }
        }
        public string Color { get; set; }
        public int Year { get; set; }
    }

    class 속성
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.Name = "남보러가니"; // setter
            Console.WriteLine(c1.Name); // getter

            Car c2 = new Car();
            c2.Name = "제네실수"; c2.Color = "Red";
            Console.WriteLine("{0}, {1}", c2.Name, c2.Color);
        }
    }
}
