//using System;
//using System.Collections;

//// 인터페이스 : 표준, 다중상속
//interface IStandard { void Run(); void Back(); }

//// 네임스페이스 : 클래스명 충돌 방지
//namespace Benz
//{
//    // 클래스 : 설계도
//    class Car : IStandard
//    {
//        #region Public Methods
//        public void Run()
//        {
//            Console.WriteLine("{0} 자동차가 달립니다.", name);
//        }   // 메서드 : 기능/동작
//        public void Back() { }
//        #endregion
//        #region Constructors
//        public Car(string name) // 생성자 : 시동, 필드 초기화
//        {
//            this.name = name;
//        }
//        public Car()
//        {
//            this.name = "벤츠"; // 기본값
//        }
//        public Car(int length)
//        {
//            this.Name = "벤츠"; // 개선
//            _Length = length;
//            names = new string[length]; //넘겨온 값으로 요소생성    
//        }
//        #endregion
//        #region Private Member Variables
//        private string name; // 필드 : 부품 
//        private string[] names; // 배열형 필드
//        private readonly int _Length; // 읽기전용 필드
//        #endregion
//        #region Public Properties
//        public string Name      // 속성 : private필드->외부공개
//        {
//            get { return name; }
//            set { name = value; }
//        }
//        public int Length { get { return _Length; } }
//        #endregion
//        #region Destructor
//        ~Car()  // 소멸자 : 폐차, 만들어진 객체 소멸될 때
//        {
//            Console.WriteLine("{0} 자동차가 폐차됨.", name);
//        }
//        #endregion
//        #region Indexer
//        public string this[int index]   // 인덱서:카탈로그 화
//        {
//            get { return names[index]; }
//            set { names[index] = value; }
//        }
//        #endregion
//        #region Iterators
//        public IEnumerator GetEnumerator() // 반복기
//        {
//            for (int i = 0; i < _Length; i++)
//            {
//                yield return names[i];
//            }
//        }
//        #endregion
//        #region Public Delegates
//        public delegate void EventHandler(); // 대리자:다중메서드호출
//        #endregion
//        #region Public Events
//        public event EventHandler Click; // 이벤트 
//        #endregion
//        #region Event Handlers
//        public void OnClick()   // 이벤트 핸들러
//        {
//            if (Click != null)
//            {
//                Click();
//            }
//        }
//        #endregion
//    }
//}

//class 자동차클래스
//{
//    static void Main(string[] args)
//    {
//        #region ...
//        Benz.Car car = new Benz.Car("A클래스");
//        car.Run(); // A클래스 자동차가 달립니다.
//        Car car1 = new Car();
//        car1.Name = "S클래스";
//        car1.Run(); // S클래스 자동차가 달립니다. 
//        Car myCar = new Car(2);
//        myCar[0] = "CLA";
//        myCar[1] = "GLA";
//        for (int i = 0; i < myCar.Length; i++)
//        {
//            Console.WriteLine(myCar[i]);
//        }
//        foreach (string name in myCar)
//        {
//            Console.WriteLine(name);
//        }
//        #endregion
//        Car btn = new Car("CLS");
//        btn.Click += new Car.EventHandler(btn.Run);
//        btn.Click += new Car.EventHandler(btn.Run);
//        btn.OnClick();
//    }
//}
