// 정적(static/스태틱)과 인스턴스(instance) 구분: static 키워드가 붙느냐 안 붙느냐?
using System;

namespace 정적과인스턴스
{
    // 상품 클래스
    public class Product
    {
        //[1] 정적 멤버: 클래스명.멤버명으로 접근
        public static string ModelName; // 상품명 저장 공간
                                        //[2] 인스턴스 멤버: 개체명.멤버명으로 접근
        public int UnitPrice; // 단가
    }

    public class 정적과인스턴스
    {
        public static void Main(string[] args)
        {
            //[1] 특정 클래스의 정적(static)인 멤버(구성요소)에 접근
            Product.ModelName = "컴퓨터";
            //[2] 특정 클래스의 인스턴스(instance) 멤버에 접근
            Product pro1 = new Product();
            pro1.UnitPrice = 1000;
            Product pro2 = new Product();
            pro2.UnitPrice = 2000;

            //[3] 사용
            Console.WriteLine("{0}, {1}, {2}"
                , Product.ModelName, pro1.UnitPrice, pro2.UnitPrice);
        }
    }
}
