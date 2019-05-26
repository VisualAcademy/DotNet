// 2차원 배열: 표 형태의 데이터, 행/열, Row/Column, 레코드/필드, 튜플/애트리뷰트
using System;

namespace 배열_이차원배열
{
    class 배열_이차원배열
    {
        static void Main(string[] args)
        {
            //[!] 2차원 배열 선언 및 초기화
            int[,] arr = { { 10, 20 }, { 30, 40 } };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("{0}\t", arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //[!] 2차원 배열 선언 및 초기화
            int[,] scores = new int[2, 2];
            scores[0, 0] = 10;
            scores[0, 1] = 20;
            scores[1, 0] = 30;
            scores[1, 1] = 40;
            for (int i = 0; i < scores.GetLength(0); i++)
            {
                for (int j = 0; j < scores.GetLength(1); j++)
                {
                    Console.Write("{0}\t", scores[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //[!] 1차원 배열의 선언과 동시에 요소수 생성과 동시에 초기화
            //int[] arr1 = new int[3] {100, 90, 80 };
            //int[] arr1 = new int[] {100, 90, 80 };
            int[] arr1 = { 100, 90, 80 };//***
            Console.WriteLine("배열의 차수: {0}", arr1.Rank);
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("{0}", arr1[i]);
            }
            Console.WriteLine();

            //[!] 2차원 배열 선언 선언과 동시에 요소수 생성과 동시에 초기화
            int[,] arr2 = new int[,] { { 10, 20, 30 }, { 40, 50, 60 } };
            // 초기화 따로 가능
            //arr1[0, 0] = 10;
            //arr1[0, 1] = 20;
            //arr1[0, 2] = 30;
            //arr1[1, 0] = 40;
            //arr1[1, 1] = 50;
            //arr1[1, 2] = 60;
            Console.WriteLine("배열의 차수: {0}", arr2.Rank); // 2차원
            for (int i = 0; i < arr2.GetLength(0); i++) //2
            {
                for (int j = 0; j < arr2.GetLength(1); j++) //3
                {
                    Console.Write("{0}\t", arr2[i, j]);
                }
                Console.WriteLine();//줄바꿈
            }
            Console.WriteLine();
        }
    }
}
