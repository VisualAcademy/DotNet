// LINQ(Language INtegrate Query): 마치 SQL문을 사용하든 프로그램에서 사용하는 쿼리문
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqCollectionDemo
{
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

    class LinqCollectionDemo
    {
        static void Main()
        {
            // 컬렉션 이니셜라이저를 사용하여 데이터 담기
            List<Car> cars = new List<Car>() {
                new Car() { Make = "Camper", Model = "Camper1", Year = 2015 },
                new Car() { Make = "Camper", Model = "Camper3", Year = 2016 },
                new Car() { Make = "SUV", Model = "AAA", Year = 2017 },
                new Car() { Make = "SUV", Model = "BBB", Year = 2018 },
                new Car() { Make = "SUV", Model = "CCC", Year = 2019 },
                new Car() { Make = "SUV", Model = "DDD", Year = 2020 }
            };

            // LINQ 사용해서 Camper만 출력 : select * from cars where make = 'Camper'
            var campers = from car in cars
                          where car.Make == "Camper"
                          select car;

            // 2015년도 이후로 출시된 자동차
            var newCars = from car in cars
                          where car.Year >= 2015
                          select car;

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
                             select new NewType { Maker = car.Make }; 
            foreach (var c in newObjects)
            {
                Console.WriteLine("{0}", c.Maker);
            }
        }
    }
}
