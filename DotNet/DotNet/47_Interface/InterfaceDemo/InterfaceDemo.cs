using System;

namespace InterfaceDemo
{
    // 배터리 표준(강제성)
    interface IBattery
    {
        string GetName(); // 메서드 시그니처만 표시
    }

    class Good : IBattery
    {
        public string GetName() => "Good";
    }

    class Bad : IBattery
    {
        public string GetName() => "Bad";
    }

    class Car
    {
        private IBattery _battery;

        //[1] 생성자의 매개 변수로 인터페이스 형식 지정
        public Car(IBattery battery)
        {
            _battery = battery; // 넘어온 개체가 _battery 필드에 저장
        }

        public void Run() => Console.WriteLine(
            "{0} 배터리를 장착한 자동차가 달립니다.", _battery.GetName());
    }

    class InterfaceDemo
    {
        static void Main(string[] args)
        {
            //[A] 넘겨주는 개체에 따라서 배터리 이름이 다르게 표시 
            var good = new Car(new Good()); good.Run();
            new Car(new Bad()).Run(); // 개체 만들기와 동시에 메서드 실행
        }
    }
}
