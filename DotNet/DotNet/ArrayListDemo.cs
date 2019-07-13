using System;
using System.Collections;

namespace ArrayListDemo
{
    class ArrayListDemo
    {
        static void Main()
        {
            Car car1 = new Car(); car1.Make = "Benz"; car1.Model = "S600";
            Car car2 = new Car(); car2.Make = "BMW"; car2.Model = "BMW7";
            Book book1 = new Book();
            book1.Author = "박용준"; book1.Title = "쉽게 배우는"; book1.ISBN = "1234";

            ArrayList lists = new ArrayList(); // 개체형을 담을 수 있는 컬렉션(배열)
            lists.Add(car1);
            lists.Add(car2);
            lists.Add(book1);       // 저장
            lists.Remove(book1);    // 삭제(삭제 안하면 아래 출력 코드에서 에러 발생)

            // 출력
            foreach (object o in lists)
            {
                Console.WriteLine("{0}, {1}", ((Car)o).Make, ((Car)o).Model);
            }
        }
    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
