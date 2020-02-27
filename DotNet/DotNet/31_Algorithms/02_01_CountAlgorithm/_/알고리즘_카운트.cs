// 짝수의 건수 구하기
using System;

public class 알고리즘_카운트
{
    public static void Main()
    {
        //[1] Input
        int[] data = { 10, 9, 4, 7, 6, 5 };
        int count = default; // 카운트 저장

        //[2] Process : COUNT
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] % 2 == 0) // 짝수
            {
                count++; // 카운트 1증가
            }
        }

        //[3] Output
        Console.WriteLine("짝수의 건수 : {0}", count); // 3
    }
}
