using System;

// 네임스페이스
namespace 클래스복습
{
    // Car 클래스
    public class Car
    {
        // name 필드
        private string name;
        // Name 속성
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        // 생성자
        public Car()
        {
            name = "BMW";
        }
        public Car(string name)
        {
            this.name = name;
        }
        // 소멸자
        ~Car()
        {
            Console.WriteLine(this.name + " 폐차됨.");
        }
        // 메서드
        public void ShowName()
        {
            Console.WriteLine("{0}", this.name);
        }
        public void GoLeft()
        {
            Console.WriteLine("{0} 좌회전", Name);
        }
        public void GoRight()
        {
            Console.WriteLine("{0} 우회전", Name);
        }
        // 대리자: 일반적으로 클래스 외부에 둠
        public delegate void CarDriver();
        // 이벤트
        public event CarDriver GoHome;
        // 이벤트 핸들러(처리기) : 메서드
        public void OnGoHome()
        {
            if (GoHome != null)
            {
                GoHome();
            }
        }
    }

    public class 클래스복습
    {
        public static void Main(string[] args)
        {
            Car car = new Car();
            car.Name = "벤츠"; // set
            Console.WriteLine("{0}", car.Name); // get

            Car hyundai = new Car("현대");
            Console.WriteLine("{0}", hyundai.Name);

            Car bmw = new Car("BMW");
            bmw.ShowName();

            Car me = new Car("마이카");
            // me.Drink();
            // me.GoLeft(); me.GoRight();
            Car.CarDriver go = new Car.CarDriver(me.GoLeft);
            go += new Car.CarDriver(me.GoRight);
            go += new Car.CarDriver(me.GoRight); // 등록
            go -= new Car.CarDriver(me.GoRight); // 제거
            go();

            Car my = new Car("통근버스"); // my.GoLeft(); my.GoRight();
            my.GoHome += my.GoLeft;
            my.GoHome += my.GoRight;
            my.OnGoHome();
        }
    }
}
