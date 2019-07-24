using System;

public class 알고리즘_합계
{
    public static void Main()
    {
        //[1] Input: n명의 국어 점수로 가정
        int[] scores = { 100, 75, 50, 37, 90, 95 };
        int sum = 0;

        //[2] Process: SUM : 주어진 범위에 주어진 조건
        for (int i = 0; i < scores.Length; i++) // 0번째 ~ 4번째
        {
            if (scores[i] >= 80)
            {
                sum += scores[i]; // SUM
            }
        }

        //[3] Output
        Console.WriteLine("{0}명의 점수 중 80점 이상의 총점 : {1}"
            , scores.Length, sum); // 285
    }
}
