using System;

namespace IndexerDemo
{
    public class Car
    {
        //[1] 필드: 배열 형식 필드
        private string[] names;
        //[2] 생성자: 생성자 매개변수로 필드의 요소수 생성 
        public Car(int length)    
        {
            names = new string[length]; // 넘겨온 길이만큼 문자열 배열 생성
        }
        //[3] 속성: 읽기전용 속성(get 접근자만 사용하여 읽기전용 속성 구현) 
        public int Length           
        {
            get                    
            {
                return names.Length;
            }
        }
        //[4] 인덱서: this[] 키워드를 사용한 속성의 확장(배열) 형식 
        public string this[int index]
        {
            get
            {
                return names[index];
            }
            set
            {
                names[index] = value;
            }
        }
    }

    class IndexerDemo
    {
        static void Main()
        {
            // 자동차 클래스의 인스턴스 생성시 생성자의 매개변수로 배열의 크기 전달
            Car car = new Car(3);

            // Car 클래스에는 인덱서가 구현되어 있기에 개체를 배열형으로 접근 가능
            car[0] = "CLA";
            car[1] = "CLS";
            car[2] = "AMG";

            // 자동차 목록 출력: for문을 통해서 개체의 값을 출력 가능
            for (int i = 0; i < car.Length; i++)
            {
                Console.WriteLine("{0}", car[i]);
            }
        }
    }
}
