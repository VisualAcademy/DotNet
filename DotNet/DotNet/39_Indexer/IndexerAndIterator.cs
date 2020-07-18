using System;
using System.Collections;

namespace IndexerAndIteratorDemo
{
    class Car
    {
        //[1] 필드
        private string[] names;
        //[2] 생성자
        public Car(int length)
        {
            names = new string[length];
        }
        //[3] 인덱서 
        public string this[int index]
        {
            get { return names[index]; }
            set { names[index] = value; }
        }
        //[4] 반복기(이터레이터)
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < names.Length; i++)
            {
                yield return names[i];
            }
        }
    }
    class IndexerAndIterator
    {
        static void Main()
        {
            Car cars = new Car(3);

            cars[0] = "CLA";
            cars[1] = "CLS";
            cars[2] = "AMG";

            foreach (var car in cars)
            {
                Console.WriteLine(car); // CLA, CLS, AMG
            }
        }
    }
}
