using System;

namespace WeekDemo
{
    /// <summary>
    /// 요일 이름을 저장해 놓는 클래스
    /// </summary>
    public class Week
    {
        //[1] 필드: 요일 문자열을 담아 놓을 수 있는 문자열 배열 
        private string[] _week; 

        //[2][1] 생성자: 매개 변수가 없는 생성자
        public Week()
        {
            Length = 7; // 기본값 초기화 
            _week = new string[Length]; // 7개의 요소를 갖는 배열 생성
        }
        //[2][2] 생성자: 매개 변수가 있는 생성자
        public Week(int length)
        {
            Length = length;
            _week = new string[Length]; 
        }

        //[3] 속성
        public int Length { get; }

        //[4] 인덱서: 개체를 배열 형태로 사용하도록 this[] 형태의 인덱서 생성 
        public string this[int index]
        {
            get { return _week[index]; }
            set { _week[index] = value; }
        }
    }

    class WeekDemo
    {
        static void Main()
        {
            //[A] 배열 형식 생성
            Week week = new Week(3);

            //[B] 인덱서로 문자열 값을 초기화
            week[0] = "일요일";
            week[1] = "월요일";
            week[2] = "화요일";

            //[C] 출력: 인덱서로 배열 형식의 필드값 출력 
            for (int i = 0; i < week.Length; i++)
            {
                Console.WriteLine($"{week[i]}");
            }
        }
    }
}
