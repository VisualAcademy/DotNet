// LINQ(Language INtegrate Query): 마치 SQL문을 사용하는 것처럼 프로그램에서 사용하는 쿼리문
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemo
{
    class LinqDemo
    {
        static void Main()
        {
            // 컬렉션에 담기
            List<Car> cars = new List<Car>() {
                new Car() { Make = "BMW", Model = "BMW1", Year = 2010 },
                new Car() { Make = "BMW", Model = "BMW3", Year = 2011 },
                new Car() { Make = "Benz", Model = "C", Year = 2012 },
                new Car() { Make = "Benz", Model = "E", Year = 2013 },
                new Car() { Make = "Benz", Model = "S", Year = 2014 },
                new Car() { Make = "Benz", Model = "CLA", Year = 2016 }
            };
            #region -
            //// 전체 출력
            //for (int i = 0; i < cars.Count; i++)
            //{
            //    Console.WriteLine("{0}, {1}, {2}"
            //        , cars[i].Make, cars[i].Model, cars[i].Year);
            //} 
            #endregion
            // LINQ 사용해서 BMW만 출력 : select * from cars where make = 'BMW'
            var bmws = from car in cars
                       where car.Make == "BMW" && car.Year == 2011
                       select car;
            //foreach (var c in bmws)
            //{
            //    Console.WriteLine("{0}, {1}, {2}", c.Make, c.Model, c.Year);
            //}
            // 2012년도 이후로 출시된 자동차
            var newCars = from car in cars
                          where car.Year >= 2012
                          select car;
            //foreach (var c in newCars)
            //{
            //    Console.WriteLine("{0}, {1}, {2}", c.Make, c.Model, c.Year);
            //}
            // 가장 최근에 출시된 자동차부터 정렬
            var orderedCars = from car in cars
                              orderby car.Year descending
                              select car;
            foreach (var c in orderedCars)
            {
                Console.WriteLine("{0}, {1}, {2}", c.Make, c.Model, c.Year);
            }

            // LINQ 식을 통해서 새로운 개체 형식으로 반환
            var newObjects = from car in cars
                             orderby car.Year ascending
                             select new NewType { Maker = car.Make }; // 익명타입
            foreach (var c in newObjects)
            {
                Console.WriteLine("{0}", c.Maker);
            }
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }

    class NewType
    {
        public string Maker { get; set; }
    }
}
