using System;

namespace StructArray
{
    //[1] 구조체 선언
    struct BusinessCard
    {
        public string Name; // 이름
        public int Age; // 나이
    }

    class StructArray
    {
        // 출력 전담 함수
        static void Print(string name, int age) 
            => Console.WriteLine($"{name}은(는) {age}살입니다.");

        static void Main()
        {
            //[A] 구조체 변수: 하나의 이름으로 하나 이상의 데이터 형식을 하나 보관
            BusinessCard biz; // 구조체 형식 변수 선언
            biz.Name = "홍길동";
            biz.Age = 17;
            Print(biz.Name, biz.Age);

            //[B] 구조체 배열: 하나의 이름으로 하나 이상의 데이터 형식을 여러 개 보관
            BusinessCard[] names = new BusinessCard[2]; // 구조체 형식 배열 선언
            names[0].Name = "백두산"; names[0].Age = 102;
            names[1].Name = "임꺽정"; names[1].Age = 31;
            for (int i = 0; i < names.Length; i++)
            {
                Print(names[i].Name, names[i].Age);
            }
        }
    }
}
