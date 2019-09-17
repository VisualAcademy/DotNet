//[?] 주어진 데이터 중에서 가장 큰 값
using System;
using System.Linq;

/// <summary>
/// 최댓값 알고리즘(Max Algorithm): (주어진 범위 + 주어진 조건)의 자료들의 가장 큰 값
/// </summary>
class MaxAlgorithm
{
    static void Main()
    {
        //[1] Initialize
        int max = int.MinValue; // 정수 형식의 데이터 중 가장 작은 값으로 초기화

        //[2] Input
        int[] numbers = { -2, -5, -3, -7, -1 }; // MAX: -1

        //[3] Process: MAX
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max) // 더 큰 데이터가 있다면
            {
                max = numbers[i]; // MAX: 더 큰 값으로 할당 
            }
        }

        //[4] Output
        Console.WriteLine($"최댓값(식): {numbers.Max()}");
        Console.WriteLine($"최댓값(문): {max}"); // -1 
    }
}

//int[] numbers = { -2, -5, -3, -7, -1 };
//numbers.Max()
//-1
