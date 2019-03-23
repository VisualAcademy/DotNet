using System;

namespace 인덱서설명
{
    public class Week
    {
        // 필드
        private string[] _WeekDay;
        // 생성자 : ctor
        public Week()
        {
            _WeekDay = new string[7];
        }
        public Week(int index)
        {
            _WeekDay = new string[index];
        }
        // 인덱서 : indexer
        public string this[int index]
        {
            get { return _WeekDay[index]; }
            set { _WeekDay[index] = value; }
        }
        // 속성 : prop
        public int Length
        {
            get { return _WeekDay.Length; }
        }
    }

    public class 인덱서설명
    {
        public static void Main(string[] args)
        {
            //배열 형식 생성
            Week week = new Week(4);

            // 인덱서 부분
            week[0] = "월";
            week[1] = "화";
            week[2] = "수";
            week[3] = "목";

            for (int i = 0; i < week.Length; i++)
            {
                Console.WriteLine("{0}", week[i]);
            }
        }
    }
}
