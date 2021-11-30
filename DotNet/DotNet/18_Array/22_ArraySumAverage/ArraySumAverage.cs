using System;

class ArraySumAverage
{
    static void Main()
    {
        int[,] scores =
        {
            { 90, 100, 0, 0 },
            { 80, 90, 0, 0 },
            { 100, 80, 0, 0 }
        };

        for (int i = 0; i < 3; i++)
        {
            scores[i, 2] = scores[i, 0] + scores[i, 1]; // SUM(합계)
            scores[i, 3] = scores[i, 2] / 2; // AVERAGE(평균)
        }

        Console.WriteLine("국어 영어 합계 평균");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                // 각 점수를 4칸 잡고 오른쪽 정렬해서 출력 
                Console.Write($"{scores[i, j],4} ");
            }
            Console.WriteLine();
        }
    }
}
