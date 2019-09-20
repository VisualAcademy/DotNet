using System;

namespace 프로퍼티
{
    public class Car
    {
        // 필드
        private string color; // 색상
                              // 생성자
        public Car()
        {
            this.color = "Black";
        }
        // 메서드로 외부에 공개
        public void SetColor(string color)
        {
            this.color = color; // this.필드 = 매개변수;
        }
        public string GetColor()
        {
            return color;
        }
        // 속성(프로퍼티;Property)
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        // 읽기전용 속성
        public string Make
        {
            get
            {
                return "한국자동차";
            }
        }
        // 쓰기전용 속성
        private string _Type;
        public string Type
        {
            set
            {
                _Type = value;
            }
        }
        // 축약형 속성 : C# 3.X 버전 이상
        //private string name;
        //public string Name
        //{
        //    get
        //    {
        //        return this.name;
        //    }
        //    set
        //    {
        //        this.name = value;
        //    }
        //}
        public string Name { get; set; }
    }

    public class 프로퍼티
    {
        public static void Main(string[] args)
        {
            //[1] Set과 Get 메서드 사용
            Car sonata = new Car();
            sonata.SetColor("Red");
            Console.WriteLine(sonata.GetColor()); // Red

            //[2] 속성을 사용
            Car whiteCar = new Car();
            whiteCar.Color = "White"; // set {}
            Console.WriteLine(whiteCar.Color); // get {}

            //[3] 읽기전용 속성
            Car k = new Car();
            Console.WriteLine(k.Make); // 읽기만 가능

            //[4] 쓰기전용 속성
            Car car = new Car();
            car.Type = "중형"; // 쓰기만 가능
                             // Console.WriteLine(car.Type); // 읽기는 불가

            //[5] 축약형 속성
            Car myCar = new Car();
            myCar.Name = "좋은차";
            Console.WriteLine(myCar.Name);
        }
    }
}
