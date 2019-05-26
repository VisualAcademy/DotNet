// 스태틱과인스턴스.cs
using System;

namespace 스태틱과인스턴스
{
    // 구조체
    public struct Customer
    {
        public static string Name; // 고객명
        public int Age; // 나이  
    }

    // 클래스
    public class Product
    {
        public static string ModelName; // 상품명 저장 공간
        public int UnitPrice; // 단가
    }

    // 실행 영역
    public class 스태틱과인스턴스
    {
        public static void Main(string[] args)
        {
            //[1] Customer 구조체의 멤버에 접근하려면???
            Customer.Name = "홍길동";
            Customer cust; // 구조체형 변수 선언 : Why? 구조체는 값형
            cust.Age = 21;
            Console.WriteLine("고객명:{0}, 나이:{1}"
              , Customer.Name, cust.Age);

            //[2] Product 클래스의 필드(멤버 변수) 사용하고자 한다?
            Product.ModelName = "컴퓨터"; // 정적(Static)인 접근
            Product pro = new Product(); // 인스턴스(Instance) 생성
            pro.UnitPrice = 1000;
            Console.WriteLine("모델명:{0}, 가격:{1}"
              , Product.ModelName, pro.UnitPrice);
        }
    }
}