using System;

public class 최솟값
{
    public static void Main()
    {
        //[1] Init
        int min = Int32.MaxValue; // 정수형 중 가장 큰 값으로 초기화
        //[2] Input
        int[] data = { -2, -5, -3, -7, -1 };
        //[3] Process : MIN
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] < min)
            {
                min = data[i]; // MIN
            }
        }
        //[4] Output
        Console.WriteLine("최솟값 : {0}", min); // -7
        //[5] Dispose
        min = 0;
    }
}