//[예제] 3명의 학생의 국어점수의 합계 및 평균을 구하는 프로그램
using System;

namespace 배열_일차원배열_성적계산
{
    class 배열_일차원배열_성적계산
    {
        static void Main(string[] args)
        {
            int 총점 = 0;
            double 평균 = 0.0; 

            //[1] 배열 선언
            int[] 국어점수;

            //[2] 배열의 요소수 생성
            국어점수 = new int[3];

            //[3] 배열 값 초기화(할당)
            국어점수[0] = 77;
            국어점수[1] = 88;
            국어점수[2] = 99;

            //[!] 총점과 평균, 배열명.Length: 요소의 총 수 
            for (int i = 0; i < 국어점수.Length; i++)
            {
                총점 += 국어점수[i]; 
            }
            평균 = 총점 / 국어점수.Length;

            Console.WriteLine($"1번 학생 점수 : {국어점수[0]}");
            Console.WriteLine($"2번 학생 점수 : {국어점수[1]}");
            Console.WriteLine($"3번 학생 점수 : {국어점수[2]}");
            Console.WriteLine($"---------------------------");
            Console.WriteLine($"총점 : {총점}");
            Console.WriteLine($"평균 : {평균}");
        }
    }
}
