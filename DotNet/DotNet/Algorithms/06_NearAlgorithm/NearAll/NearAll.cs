//[?] 가까운 값 모두 구하기: 가까운값(NEAR): 차이의 절댓값의 최솟값 
using System;
using System.Collections.Generic;

class NearAll
{
    static void Main()
    {
        int[] data = { 10, 20, 23, 27, 17 };
        int target = 25; // 25와 가까운 값들은 23, 27
        List<int> nears = new List<int>(); // 가까운 값들...
        int min = Int32.MaxValue;

        //[1] MIN 알고리즘: 차이의 최솟값 구하기 
        for (int i = 0; i < data.Length; i++)
        {
            if (Math.Abs(data[i] - target) < min)
            {
                min = Math.Abs(data[i] - target);
            }
        }

        Console.WriteLine($"차이의 최솟값: {min}"); // 2

        //[2] NEAR 알고리즘: 차이의 최솟값이 min인 값들을 다시 한번 비교 
        for (int i = 0; i < data.Length; i++)
        {
            if (Math.Abs(data[i] - target) == min)
            {
                nears.Add(data[i]); // 가까운 값들 모두 저장
            }
        }

        // 가까운 값들 출력
        foreach (var n in nears)
        {
            Console.WriteLine(n);
        }
    }
}
