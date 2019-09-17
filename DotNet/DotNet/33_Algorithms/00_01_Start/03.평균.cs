using System;

public class 평균
{
    public static void Main()
    {
        //[1] 입력
        int[] data = {50, 65, 78, 90, 95 };
        int sum = 0; 
        int count = 0;
        double avg = 0.0; // 평균이 저장될 변수
        //[2] 처리 : AVG = SUM / COUNT
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] >= 80 && data[i] <= 95)
            {
                sum += data[i];
                count++;
            }
        }
        avg = sum / (double)count; // 캐스팅(형식변환) 필요 : 3 -> 3.0
        //[3] 출력
        Console.WriteLine(
            "80점 이상 95점 이하인 자료의 평균 : {0}", avg); // 92.5
    }    
}