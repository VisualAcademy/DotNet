//[?] public 필드: 필드는 대부분 private으로 구현하지만, public도 가능합니다. 
using System;

namespace PublicField
{
    class Category
    {
        // public 필드(멤버 변수;전역 변수)
        // public 필드는 앞으로 배울 다음과 같은 방식으로 대체 권장: 
        // (1) private 필드 + public 속성(Property)
        // (2) 자동 속성(Auto Property)으로 구현
        public string CategoryName;
    }

    class PublicField
    {
        static void Main()
        {
            Category book = new Category();
            book.CategoryName = "책";
            Console.WriteLine(book.CategoryName); // 책 
        }
    }
}
