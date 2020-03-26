// List<Object>: 새로운 개체(클래스)의 컬렉션을 담아놓을 수 있는 그릇
// List<T>: List<int>, List<string>, List<All>
using System;
using System.Collections.Generic;

namespace ListOfObject
{
    //[1] 지역과 국번 저장 클래스 선언
    public class AreaCode
    {
        public string Number { get; set; }
        public string AreaName { get; set; }
    }
    class ListOfObject
    {
        static void Main()
        {
            //[2] 제네릭 리스트 개체 생성
            List<AreaCode> areas = new List<AreaCode>();

            //[3] 컬렉션에 포함될 각각의 개체 생성
            //[3][1] 속성으로 개체 초기화
            AreaCode seoul = new AreaCode();
            seoul.Number = "02";
            seoul.AreaName = "서울";

            //[3][2] 개체 이니셜라이저로 개체 초기화
            AreaCode sejong = new AreaCode
            {
                Number = "044", AreaName = "세종"
            };            

            //[4] 컬렉션에 개체 등록
            areas.Add(seoul);
            areas.Add(sejong);

            //[5] 컬렉션의 값을 반복해서 속성을 사용해서 출력
            foreach (var area in areas)
            {
                Console.WriteLine($"번호: {area.Number}, 지역: {area.AreaName}");
            }
        }
    }
}
