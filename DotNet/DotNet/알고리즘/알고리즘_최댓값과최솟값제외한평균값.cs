// 5개의 자연수 배열 중 최댓값과 최솟값을 제외한 나머지 3개의 평균값을 구하는 프로그램
using System;

class 알고리즘_최댓값과최솟값제외한평균값
{
    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50 }; // 30

        int sum = 0;
        int max = Int32.MinValue; // 해당 범위에서 가장 작은 값으로 초기화
        int min = Int32.MaxValue; // 해당 범위에서 가장 큰 값으로 초기화
        double avg = 0.0;

        for (int i = 0; i < arr.Length; i++)
        {
            // 합계 알고리즘
            sum = sum + arr[i];

            // 최댓값 알고리즘
            if (max < arr[i])
            {
                max = arr[i];
            }

            // 최솟값 알고리즘
            if (min > arr[i])
            {
                min = arr[i];
            }
        }

        Console.WriteLine("합계 {0}, 최댓값 {1}, 최솟값 {2}", sum, max, min);

        // 최댓값, 최솟값 제외한 평균
        avg = (sum - max - min) / (double)(arr.Length - 2);

        Console.WriteLine("최댓값, 최솟값 제외한 평균: {0:F2}", avg);
    }
}
