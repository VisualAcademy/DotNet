using System;

namespace 배열_배열의배열
{
    class 배열_배열의배열
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2016년 2월은 며칠까지? {0}", DateTime.DaysInMonth(2016, 2));

            //(12월*각각의 일수)만큼의 공간을 생성하고 1로 초기화
            int[][] intDaysInMonth = new int[12][];//12개월 참조
                                             
            //intDaysInMonth[0] = new int[31]; // 1월달 31일 요소 생성
            for (int i = 0; i < 12; i++)
            {
                intDaysInMonth[i] = new int[DateTime.DaysInMonth(DateTime.Now.Year, i + 1)];
                for (int j = 0; j < DateTime.DaysInMonth(DateTime.Now.Year, i + 1); j++)
                {
                    intDaysInMonth[i][j] = 1;//각각의 요소를 1로초기화                    
                }
            }

            //위에서 초기화된 각각의 공간에 있는 값의 합계 : 366          
            int sum = 0;//합계 : 365+1
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < DateTime.DaysInMonth(DateTime.Now.Year, i + 1); j++)
                {
                    sum += intDaysInMonth[i][j];
                }
            }
            Console.WriteLine("2016년 1년 전체 일수: {0}", sum);
        }
    }
}
