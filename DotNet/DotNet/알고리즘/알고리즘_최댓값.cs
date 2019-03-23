using System;

public class 알고리즘_최댓값
{
    public static void Main()
    {
        //[1] Init
        int max = Int32.MinValue; // 정수형 데이터 중 작은 값으로 초기화 
                                  
        //[2] Input
        int[] data = { -2, -5, -3, -7, -1 };

        //[3] Process : MAX
        for (int i = 0; i < data.Length; i++)
        {
            if (max < data[i])
            {
                max = data[i]; // MAX : 더 큰 값으로 할당
            }
        }

        //[4] Output
        Console.WriteLine("최댓값 : {0}", max); // -1
                                             
        //[5] Dispose
        max = 0;
    }
}
