// <별점 테러 방지 프로그램 />
// "제품에 대한 별점 중에서 최솟값과 최댓값을 뺀 별점들의 평균값을 구하는 프로그램"
using System;

class RatingAverage
{
    static void Main()
    {
        //[1] Input
        int[] ratings = { 1, 2, 3, 4, 5 }; // int ratings[] = { 1, 2, 3, 4, 5 };
        int max = ratings[0]; // 0번째 인덱스의 값으로 초기화
        int min = ratings[0]; // 0번째 인덱스의 값으로 초기화
        int sum = ratings[0]; // 0번째 인덱스의 값으로 초기화

        //[2] Process: 하나의 for 문으로 합계, 최댓값, 최솟값을 계산
        for (int i = 1; i < 5; i++) // 인덱스를 1부터 시작 주의
        {
            sum += ratings[i];

            if (ratings[i] > max)
            {
                max = ratings[i]; // 최댓값 구하기 
            }
            if (ratings[i] < min)
            {
                min = ratings[i]; // 최솟값 구하기 
            }
        }
        int rating = (sum - max - min) / (5 - 2);

        //[3] Output
        Console.WriteLine($"최댓값: {max}, 최솟값: {min}");
        Console.WriteLine($"최종 별점: {rating}");
    }
}
