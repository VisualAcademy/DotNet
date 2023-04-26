using System;

class AlternatingSeriesSum
{
    static void Main()
    {
        // 교차 수열의 합을 초기화합니다.
        double sum = 0.0;

        // 1부터 99까지의 정수를 반복합니다.
        for (int i = 1; i <= 99; i++)
        {
            // 분수 값을 계산합니다.
            double fraction = (double)i / (i + 1);

            // 홀수 인덱스일 경우 합계에 더하고, 짝수 인덱스일 경우 합계에서 뺍니다.
            if (i % 2 == 1)
            {
                sum += fraction;
            }
            else
            {
                sum -= fraction;
            }
        }

        // 결과를 출력합니다. (예: 0.69)
        Console.WriteLine($"결과: {sum:F2}");
    }
}
