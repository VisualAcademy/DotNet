// 가까운값(NEAR) : 차이값의 절대값의 최솟값...
using System;

class 알고리즘_가까운값2
{
    static void Main()
    {
        //[1] Input
        int[] data = { 10, 20, 30, 27, 17 };
        int target = 25;                        // target과 가까운 값
        int near = 0;                           // 가까운값 : 27
        int min = Int32.MaxValue;               // 차이값의 절대값의 최소값

        //[2] Process : NEAR
        for (int i = 0; i < data.Length; i++)   // 범위
        {
            int temp = Abs(data[i] - target);   // 차이값의 절대값
            if (temp < min)
            {
                min = temp;                     // 최솟값 알고리즘
                near = data[i];                 // 최종적으로 가까운값이 저장됨
            }
        }

        //[3] Output
        Console.WriteLine("{0}와 가까운값 : {1}", target, near); // 25,27
    }

    /// <summary>
    /// Math.Abs() 함수와 동일한 기능을 구현해 봄
    /// </summary>
    public static int Abs(int num)
    {
        return (num < 0) ? -num : num;
    }
}

