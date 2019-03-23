using System;

namespace 구조체
{
    //[!] 구조체 선언
    public struct BusinessCard
    {
        public string Name;     // 이름
        public int Age;         // 나이
    }

    public class 구조체
    {
        //[!] 출력 전담 함수
        public static void Print(object name, object age)
        {
            Console.WriteLine("{0}은(는) {1}살입니다.", name, age);
        }

        public static void Main(string[] args)
        {
            //[1] 변수(Variable) : 하나의 이름으로 하나의 데이터 형식을 하나만 보관
            string name = "홍길동";
            int age = 21;
            Print(name, age);

            //[2] 배열(Array) : 하나의 이름으로 하나의 데이터 형식을 하나 이상(여러 개) 보관
            object[] address = new object[2];
            address[0] = "백두산";
            address[1] = 100;
            Print(address[0], address[1]);

            //[3] 구조체 변수: 하나의 이름으로 하나 이상의 데이터 형식을 하나 보관, 
            // 하나의 이름으로 묶어서(구조화해서) 관리
            BusinessCard biz; // 구조체(새로운 데이터 형식) 형 변수 선언
            biz.Name = "임꺽정";
            biz.Age = 40;
            Print(biz.Name, biz.Age);

            //[4] 구조체 배열: 하나의 이름으로 하나 이상의 데이터 형식을 여러 개 보관
            BusinessCard[] names = new BusinessCard[2];
            names[0].Name = "한라산"; names[0].Age = 1;
            names[1].Name = "지리산"; names[1].Age = 11;
            for (int i = 0; i < names.Length; i++)
            {
                Print(names[i].Name, names[i].Age);
            }
        }
    }
}
