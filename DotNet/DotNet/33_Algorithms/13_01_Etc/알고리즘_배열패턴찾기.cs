using System;

namespace 알고리즘_배열패턴찾기
{
    class 알고리즘_배열패턴찾기
    {
        static void Main(string[] args)
        {
            int[] S = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] T = new int[] { 8, 9, 10 };
            int k = 0;
            bool flag = false;
            int index = 0;

            for (int i = 0; i < S.Length - 2; i++)
            {
                k = i; // 소스 배열의 시작 위치 지정
                for (int j = 0; j < T.Length; j++) // T[0], T[1], T[2] 매번 비교
                {
                    if (S[k] == T[j])
                    {
                        if (j == 2) // 0, 1, 2 즉 3번 동일하게 나왔다면...
                        {
                            flag = true; // Console.WriteLine("동일 패턴이 존재함");
                            index = i; // 현재 시작 인덱스 위치 보관
                        }
                    }
                    else
                    {
                        break; // 안쪽 for문 빠져나옴
                    }

                    Console.Write("{0}\t", S[k]); // 1, 2, 3
                    k = k + 1;
                }
            }
            Console.WriteLine(); // 줄바꿈

            if (flag)
            {
                Console.WriteLine("{0} 인덱스에서 동일 패턴이 존재함", index);
            }
            else {
                Console.WriteLine("패턴이 존재하지 않음");
            }
        }
    }
}
