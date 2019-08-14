//[?] 주어진 데이터 중에서 가장 작은 [짝수] 값
using System;
using System.Linq;
using static System.Console;

/// <summary>
/// 최솟값 알고리즘(Min Algorithm): (주어진 범위 + 주어진 조건)의 자료들의 가장 작은 값
/// </summary>
class MinAlgorithm
{
    static void Main()
    {
        //[1] Initialize
        var min = Int32.MaxValue; // 정수 형식의 데이터 중 가장 큰 값으로 초기화

        //[2] Input: 이진수로 표현 + 숫자 구분자 사용({ 2, 5, 3, 7, 1 })
        int[] numbers = { 0b0010, 0B_0101, 0b0011, 0B_0111, 0b0000_0001 };

        //[3] Process: MIN
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min && numbers[i] % 2 == 0)
            {
                min = numbers[i]; // MIN: 더 작은 값으로 할당 
            }
        }

        //[4] Output
        WriteLine($"짝수 최솟값(식): {numbers.Where(n => n % 2 == 0).Min()}");
        WriteLine($"짝수 최솟값(문): {min}");
    }
}

//int[] numbers = { 0b0010, 0B_0101, 0b0011, 0B_0111, 0b0000_0001 };
//numbers.Where(n => n % 2 == 0).Min()
//2
