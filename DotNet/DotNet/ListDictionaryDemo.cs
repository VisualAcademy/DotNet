using System;
using System.Collections.Specialized;

namespace ListDictionaryDemo
{
    class ListDictionaryDemo
    {
        static void Main(string[] args)
        {
            //[1] 개체의 인스턴스 생성 -> 속성값 초기화
            Book b1 = new Book();
            b1.Title = "ASP.NET"; b1.Author = "박용준"; b1.ISBN = "1234";

            //[2] Object Intializer(개체 초기화자)
            Book b2 = new Book() { Title = "C#", Author = "홍길동", ISBN = "4321" };

            //[!] ListDictionary 클래스에 개체 담기 : Key, Value 쌍으로 개체 값 저장
            ListDictionary ld = new ListDictionary();
            ld.Add("첫번째", b1);
            ld.Add("두번째", b2);

            Console.WriteLine(((Book)ld["첫번째"]).Title);

            Book b = (Book)ld["두번째"];
            Console.WriteLine("{0}, {1}, {2}", b.Title, b.Author, b.ISBN);
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
