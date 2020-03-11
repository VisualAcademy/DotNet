using System;
using System.Collections;

/*
 *[1] 네임스페이스: 클래스명 충돌 방지 
 */
namespace CarWorld
{
    //[2] 인터페이스: 표준, 다중상속
    interface IStandard { void Run(); }

    /// <summary>
    /// [3] 클래스: 설계도
    /// </summary>
    class Car : IStandard
    {
        #region [4] 필드: Private Member Variables
        private string name; // 필드 : 부품 
        private string[] names; // 배열형 필드
        private readonly int _Length; // 읽기전용 필드
        #endregion

        #region [5] 생성자: Constructors
        public Car()
        {
            this.name = "좋은차"; // 필드를 기본값으로 초기화
        }
        public Car(string name) // 생성자 : 시동, 필드 초기화
        {
            this.name = name;
        }
        public Car(int length)
        {
            this.Name = "좋은차";
            _Length = length; // 읽기전용 필드는 생성자에 의해서 초기화 가능
            names = new string[length]; //넘겨온 값으로 요소생성    
        }
        #endregion

        #region [6] 메서드: Public Methods
        // 메서드 : 기능/동작
        public void Run() => Console.WriteLine("{0} 자동차가 달립니다.", name);
        #endregion

        #region [7] 속성: Public Properties
        public string Name      // 속성 : private필드->외부공개
        {
            get { return name; }
            set { name = value; }
        }
        public int Length { get { return _Length; } }
        #endregion

        #region [8] 소멸자: Destructor
        ~Car()  // 소멸자 : 폐차, 만들어진 객체 소멸될 때
        {
            Console.WriteLine("{0} 자동차가 폐차됨.", name);
        }
        #endregion

        #region [9] 인덱서: Indexer
        public string this[int index]   // 인덱서:카탈로그 화
        {
            get { return names[index]; }
            set { names[index] = value; }
        }
        #endregion

        #region [10] 이터레이터: Iterators
        public IEnumerator GetEnumerator() // 반복기
        {
            for (int i = 0; i < _Length; i++)
            {
                yield return names[i];
            }
        }
        #endregion

        #region [11] 대리자: Public Delegates
        public delegate void EventHandler(); // 대리자:다중메서드호출
        #endregion

        #region [12] 이벤트: Public Events
        public event EventHandler Click; // 이벤트 
        #endregion

        #region [13] 이벤트 처리기: Event Handlers
        public void OnClick()   // 이벤트 핸들러
        {
            if (Click != null)
            {
                Click();
            }
        }
        #endregion
    }

    class CarWorld
    {
        static void Main()
        {
            //[A] 클래스, 생성자, 메서드 테스트
            Car campingCar = new Car("캠핑카");
            campingCar.Run(); // 캠핑카 자동차가 달립니다.

            //[B] 속성 테스트
            Car sportsCar = new Car();
            sportsCar.Name = "스포츠카";
            sportsCar.Run(); // 스포츠카 자동차가 달립니다. 

            //[C] 인덱서 테스트
            Car cars = new Car(2);
            cars[0] = "1번 자동차";
            cars[1] = "2번 자동차";
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            //[D] 이터레이터 테스트
            foreach (string name in cars)
            {
                Console.WriteLine(name);
            }

            //[E] 대리자, 이벤트, 이벤트 처리기 테스트
            Car btn = new Car("전기자동차");
            btn.Click += new Car.EventHandler(btn.Run);
            btn.Click += new Car.EventHandler(btn.Run);
            btn.OnClick();
        }
    }
}
