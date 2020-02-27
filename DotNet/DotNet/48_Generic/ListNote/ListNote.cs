//[?] 리스트(List): 배열, 컬렉션, 리스트, ... -> 여러 개의 값을 하나의 변수에 담기
using System;
using System.Collections.Generic;

namespace ListNote
{
    /// <summary>
    /// 연간 일사량 
    /// </summary>
    public class Insolation
    {
        /// <summary>
        /// 월(1월부터 12월까지) 
        /// </summary>
        public int Month { get; set; }
        /// <summary>
        /// 일사량 값
        /// </summary>
        public float Value { get; set; }
    }

    class ListNote
    {
        static void Main()
        {
            //[1] 개체 형식의 리스트 생성: 컬렉션 이니셜라이저로 값 초기화 
            List<Insolation> insolations = new List<Insolation>()
            {                
                new Insolation { Month = 1, Value = 0.3f },
                new Insolation { Month = 2, Value = 0.6f },
                new Insolation { Month = 3, Value = 0.9f },
                new Insolation { Month = 4, Value = 1.2f }
            };

            //[2] Add() 메서드로 리스트에 값 추가: 개체 이니셜라이저로 값 초기화 
            insolations.Add(new Insolation() { Month = 5, Value = 1.5f });
            insolations.Add(new Insolation() { Month = 6, Value = 1.8f });
            insolations.Add(new Insolation() { Month = 7, Value = 1.6f });
            insolations.Add(new Insolation() { Month = 8, Value = 1.5f });

            //[3] AddRange() 메서드로 리스트에 값들 추가 
            var tempInsolations = new List<Insolation>()
            {
                new Insolation { Month = 9, Value = 1.2f },
                new Insolation { Month = 10, Value = 0.9f },
                new Insolation { Month = 11, Value = 0.6f },
                new Insolation { Month = 12, Value = 0.1f }
            };
            insolations.AddRange(tempInsolations);

            //[4] 리스트 출력
            Console.WriteLine("연간 일사량");
            foreach (var insolation in insolations)
            {
                Console.WriteLine($"{insolation.Month:00} - {insolation.Value}");
            }
        }
    }
}
