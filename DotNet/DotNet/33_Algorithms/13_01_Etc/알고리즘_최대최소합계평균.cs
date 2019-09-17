class 알고리즘_최대최소합계평균
{
    static void Main()
    {
        int[] r = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        int sum = 0;    // 0
        int max = 0;    // 범위에서 최솟값
        int min = 100;  // 범위에서 최댓값
        int i = 0; // i = i + 1
        float avg = 0.0f; 

        do
        {
            i = i + 1;

            if (i == 12)
            {
                break;
            }
            else
            {
                if (max < r[i])
                {
                    max = r[i]; // 최댓값 알고리즘
                }
                if (min > r[i])
                {
                    min = r[i]; // 최솟값 알고리즘
                }
                sum = sum + r[i]; // 합계 알고리즘 
            }
        } while (true);

        i = i - 1; // 11개
        avg = sum / i; // 평균 알고리즘: 총점/카운트 
        System.Console.WriteLine($"{max} {min} {sum} {avg}");
    }
}
